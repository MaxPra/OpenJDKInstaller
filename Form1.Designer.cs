namespace OpenJDKInstaller
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tfInstallationPath = new System.Windows.Forms.TextBox();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInstall = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tfZipFolderPath = new System.Windows.Forms.TextBox();
            this.btnSelectOpenJDK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tfInstallationPath
            // 
            this.tfInstallationPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfInstallationPath.Location = new System.Drawing.Point(26, 106);
            this.tfInstallationPath.Name = "tfInstallationPath";
            this.tfInstallationPath.Size = new System.Drawing.Size(295, 24);
            this.tfInstallationPath.TabIndex = 2;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(341, 106);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPath.TabIndex = 3;
            this.btnSelectPath.Text = "select";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select the installation path:";
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(201, 158);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(75, 23);
            this.btnInstall.TabIndex = 5;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Your zipfolder path:";
            // 
            // tfZipFolderPath
            // 
            this.tfZipFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfZipFolderPath.Location = new System.Drawing.Point(26, 55);
            this.tfZipFolderPath.Name = "tfZipFolderPath";
            this.tfZipFolderPath.Size = new System.Drawing.Size(295, 24);
            this.tfZipFolderPath.TabIndex = 6;
            // 
            // btnSelectOpenJDK
            // 
            this.btnSelectOpenJDK.Location = new System.Drawing.Point(341, 55);
            this.btnSelectOpenJDK.Name = "btnSelectOpenJDK";
            this.btnSelectOpenJDK.Size = new System.Drawing.Size(75, 23);
            this.btnSelectOpenJDK.TabIndex = 9;
            this.btnSelectOpenJDK.Text = "select";
            this.btnSelectOpenJDK.UseVisualStyleBackColor = true;
            this.btnSelectOpenJDK.Click += new System.EventHandler(this.btnSelectOpenJDK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 213);
            this.Controls.Add(this.btnSelectOpenJDK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tfZipFolderPath);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.tfInstallationPath);
            this.MaximumSize = new System.Drawing.Size(476, 252);
            this.MinimumSize = new System.Drawing.Size(476, 252);
            this.Name = "Form1";
            this.Text = "OpenJDKInstaller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tfInstallationPath;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tfZipFolderPath;
        private System.Windows.Forms.Button btnSelectOpenJDK;
    }
}

