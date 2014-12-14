namespace WindowsFormsApplication1
{
    partial class AutoLogoff
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelInformation = new System.Windows.Forms.Label();
            this.HideButton = new System.Windows.Forms.Button();
            this.labelElapsedIdleTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.BackColor = System.Drawing.Color.Transparent;
            this.labelInformation.Location = new System.Drawing.Point(2, 9);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(376, 13);
            this.labelInformation.TabIndex = 0;
            this.labelInformation.Text = "Note: This session will be automatically disconnected after 15 minutes idle time";
            // 
            // HideButton
            // 
            this.HideButton.Location = new System.Drawing.Point(303, 28);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(75, 23);
            this.HideButton.TabIndex = 1;
            this.HideButton.Text = "&OK";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelElapsedIdleTime
            // 
            this.labelElapsedIdleTime.AutoSize = true;
            this.labelElapsedIdleTime.Location = new System.Drawing.Point(66, 33);
            this.labelElapsedIdleTime.Name = "labelElapsedIdleTime";
            this.labelElapsedIdleTime.Size = new System.Drawing.Size(36, 13);
            this.labelElapsedIdleTime.TabIndex = 2;
            this.labelElapsedIdleTime.Text = "0 sec.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Idle since: ";
            // 
            // AutoLogoff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 70);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelElapsedIdleTime);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.labelInformation);
            this.Name = "AutoLogoff";
            this.Opacity = 0.7D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Notice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Button HideButton;
        private System.Windows.Forms.Label labelElapsedIdleTime;
        private System.Windows.Forms.Label label2;
    }
}

