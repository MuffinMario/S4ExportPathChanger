namespace shitty_app_for_saving_time
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.applyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(337, 40);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 0;
            this.applyButton.Text = "Auswählen";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.MaximumSize = new System.Drawing.Size(400, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(314, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hier kannst du deinen Siedler IV Editor Exportierpfad auswählen. \r\nFunktioniert a" +
    "uch während der Editor läuft.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // folderButton
            // 
            this.folderButton.Location = new System.Drawing.Point(267, 40);
            this.folderButton.Name = "folderButton";
            this.folderButton.Size = new System.Drawing.Size(59, 20);
            this.folderButton.TabIndex = 2;
            this.folderButton.Text = "Ändern";
            this.folderButton.UseVisualStyleBackColor = true;
            this.folderButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 3;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.infoLabel.Location = new System.Drawing.Point(269, 66);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(87, 13);
            this.infoLabel.TabIndex = 4;
            this.infoLabel.Text = "Ordner geändert!";
            this.infoLabel.Visible = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(161, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(423, 88);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.folderButton);
            this.Controls.Add(this.applyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = S4EditorExportChanger.Properties.Resources.Siedler_Baum;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "S4Editor Export Path Changer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button folderButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

