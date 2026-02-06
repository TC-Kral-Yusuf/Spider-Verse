namespace Spider_Patcher
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            lstOutput = new ListBox();
            SuspendLayout();
            // 
            // lstOutput
            // 
            lstOutput.BackColor = Color.Black;
            lstOutput.BorderStyle = BorderStyle.FixedSingle;
            lstOutput.Font = new Font("Aptos SemiBold", 12F, FontStyle.Bold);
            lstOutput.ForeColor = Color.Lime;
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(12, 12);
            lstOutput.Name = "lstOutput";
            lstOutput.SelectionMode = SelectionMode.None;
            lstOutput.Size = new Size(756, 522);
            lstOutput.TabIndex = 0;
            lstOutput.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(780, 557);
            Controls.Add(lstOutput);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Spider-Patcher";
            FormClosing += Main_FormClosing;
            Shown += Main_Shown;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstOutput;
    }
}
