using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;


namespace WindowsFormsApplication1
{
    public partial class AutoLogoff : Form
    {
        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.
        delegate void SetTextCallback(int value);

        public AutoLogoff()
        {
            InitializeComponent();
            InitNumberOfMinutesBeforeLogoff();
            labelInformation.Text = "Note: This session will be automatically disconnected after "+NumberOfMinutesBeforeLogoff+" minutes idle time";
             
            Thread workerThread = new Thread(new ThreadStart(this.DoWork));
            workerThread.Start();
        }

        private void InitNumberOfMinutesBeforeLogoff()
        {
            String envVariable = Environment.GetEnvironmentVariable("AUTOLOGOFF_NB_IDLE_MINUTES");
            if(envVariable != null){
                NumberOfMinutesBeforeLogoff = int.Parse(envVariable);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void setIdleLabel( int elapsedIdelTime ){
            String text = elapsedIdelTime + " sec.";
            if (this.labelElapsedIdleTime.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setIdleLabel);
                this.Invoke(d, new object[] { elapsedIdelTime });
            }
            else
            {
                labelElapsedIdleTime.Text = text;
            } 
        }

        private void DoWork()
        {
            bool _shouldStop = false;
            while (!_shouldStop)
            {
                int elapsedIdelTime=GetLastInputTime();
                this.setIdleLabel(elapsedIdelTime);
                if (elapsedIdelTime > 60 * NumberOfMinutesBeforeLogoff) 
                {
                    ExitWindowsEx(0x10, 0);
                    _shouldStop = true;
                }
                Thread.Sleep(1000); //check once per min.
            }

        }
        

        [StructLayout(LayoutKind.Sequential)]
        struct LASTINPUTINFO
        {
            public static readonly int SizeOf = Marshal.SizeOf(typeof(LASTINPUTINFO));

            [MarshalAs(UnmanagedType.U4)]
            public int cbSize;
            [MarshalAs(UnmanagedType.U4)]
            public UInt32 dwTime;
        }


        [DllImport("user32.dll")]
        static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ExitWindowsEx(uint uFlags, uint dwReason);


        static int GetLastInputTime()
        {
            int idleTime = 0;
            LASTINPUTINFO lastInputInfo = new LASTINPUTINFO();
            lastInputInfo.cbSize = Marshal.SizeOf(lastInputInfo);
            lastInputInfo.dwTime = 0;

            int envTicks = Environment.TickCount;

            if (GetLastInputInfo(ref lastInputInfo))
            {
                int lastInputTick = (int)lastInputInfo.dwTime;

                idleTime = envTicks - lastInputTick;
            }

            return ((idleTime > 0) ? (idleTime / 1000) : 0);
        }


        public int NumberOfMinutesBeforeLogoff = 30;
    }

    
}
