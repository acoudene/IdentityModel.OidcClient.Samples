namespace WindowsFormsControlLibrary1
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.Output = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // Output
      // 
      this.Output.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Output.Location = new System.Drawing.Point(0, 0);
      this.Output.Multiline = true;
      this.Output.Name = "Output";
      this.Output.Size = new System.Drawing.Size(606, 156);
      this.Output.TabIndex = 0;
      this.Output.Text = "Sign in from .Net Winforms...";
      // 
      // UserControl1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.Output);
      this.Name = "UserControl1";
      this.Size = new System.Drawing.Size(606, 156);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.TextBox Output;
  }
}
