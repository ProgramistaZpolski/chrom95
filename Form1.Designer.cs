namespace Chrom
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.backButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.newTabButton = new System.Windows.Forms.Button();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(13, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(26, 24);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(45, 13);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(26, 24);
            this.forwardButton.TabIndex = 1;
            this.forwardButton.Text = ">";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.Location = new System.Drawing.Point(907, 13);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(36, 23);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Idź";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // newTabButton
            // 
            this.newTabButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newTabButton.Location = new System.Drawing.Point(949, 13);
            this.newTabButton.Name = "newTabButton";
            this.newTabButton.Size = new System.Drawing.Size(75, 23);
            this.newTabButton.TabIndex = 3;
            this.newTabButton.Text = "Nowa karta";
            this.newTabButton.UseVisualStyleBackColor = true;
            this.newTabButton.Click += new System.EventHandler(this.newTabButton_Click);
            // 
            // urlBox
            // 
            this.urlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlBox.Location = new System.Drawing.Point(77, 15);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(824, 20);
            this.urlBox.TabIndex = 4;
            this.urlBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urlBox_KeyPress);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(-2, 41);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1048, 479);
            this.tabControl.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Controls.Add(this.WebBrowser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1040, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // WebBrowser
            // 
            this.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowser.Location = new System.Drawing.Point(3, 3);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(1034, 447);
            this.WebBrowser.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1034, 447);
            this.webBrowser1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 519);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.newTabButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.backButton);
            this.Name = "Form1";
            this.Text = "Chrom";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button newTabButton;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser WebBrowser;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

