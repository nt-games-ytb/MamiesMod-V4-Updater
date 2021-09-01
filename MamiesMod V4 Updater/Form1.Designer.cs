namespace MamiesMod_V4_Updater
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.downloadBar = new MetroFramework.Controls.MetroProgressBar();
            this.downloadText = new System.Windows.Forms.Label();
            this.downloadName = new System.Windows.Forms.Label();
            this.updateLabel = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.versionText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // downloadBar
            // 
            this.downloadBar.Location = new System.Drawing.Point(25, 150);
            this.downloadBar.Name = "downloadBar";
            this.downloadBar.Size = new System.Drawing.Size(500, 23);
            this.downloadBar.Style = MetroFramework.MetroColorStyle.Magenta;
            this.downloadBar.TabIndex = 0;
            this.downloadBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // downloadText
            // 
            this.downloadText.AutoSize = true;
            this.downloadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadText.ForeColor = System.Drawing.Color.White;
            this.downloadText.Location = new System.Drawing.Point(150, 90);
            this.downloadText.Name = "downloadText";
            this.downloadText.Size = new System.Drawing.Size(196, 31);
            this.downloadText.TabIndex = 1;
            this.downloadText.Text = "Download : 0%";
            // 
            // downloadName
            // 
            this.downloadName.AutoSize = true;
            this.downloadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadName.ForeColor = System.Drawing.Color.White;
            this.downloadName.Location = new System.Drawing.Point(22, 131);
            this.downloadName.Name = "downloadName";
            this.downloadName.Size = new System.Drawing.Size(75, 16);
            this.downloadName.TabIndex = 6;
            this.downloadName.Text = "Download :";
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateLabel.ForeColor = System.Drawing.Color.White;
            this.updateLabel.Location = new System.Drawing.Point(21, 60);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(191, 24);
            this.updateLabel.TabIndex = 7;
            this.updateLabel.Text = "Installing the update...";
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLabel.ForeColor = System.Drawing.Color.White;
            this.closeLabel.Location = new System.Drawing.Point(347, 60);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(178, 24);
            this.closeLabel.TabIndex = 8;
            this.closeLabel.Text = "Do not close this tab";
            this.closeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // versionText
            // 
            this.versionText.AutoSize = true;
            this.versionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionText.ForeColor = System.Drawing.Color.White;
            this.versionText.Location = new System.Drawing.Point(402, 31);
            this.versionText.Name = "versionText";
            this.versionText.Size = new System.Drawing.Size(123, 20);
            this.versionText.TabIndex = 9;
            this.versionText.Text = "Version : 4.0.0.0";
            this.versionText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 200);
            this.Controls.Add(this.versionText);
            this.Controls.Add(this.closeLabel);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.downloadName);
            this.Controls.Add(this.downloadText);
            this.Controls.Add(this.downloadBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "MamiesMod V4 Updater";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar downloadBar;
        private System.Windows.Forms.Label downloadText;
        private System.Windows.Forms.Label downloadName;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Label versionText;
    }
}

