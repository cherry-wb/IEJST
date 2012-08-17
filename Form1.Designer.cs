namespace IEJavascriptSpeedTester
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.wbTest = new System.Windows.Forms.WebBrowser();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtOutput.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.Color.Black;
            this.txtOutput.Location = new System.Drawing.Point(0, 298);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(327, 73);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.Text = "";
            // 
            // wbTest
            // 
            this.wbTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbTest.Location = new System.Drawing.Point(0, 0);
            this.wbTest.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbTest.Name = "wbTest";
            this.wbTest.Size = new System.Drawing.Size(327, 298);
            this.wbTest.TabIndex = 1;
            this.wbTest.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.wbTest_PreviewKeyDown);
            this.wbTest.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wbTest_Navigated);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 371);
            this.Controls.Add(this.wbTest);
            this.Controls.Add(this.txtOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kentaromiura IE Jst: Internet Explorer Javascript speed tester";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.WebBrowser wbTest;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

