namespace KeyboardSpy
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
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.tbText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // numUpDown
            // 
            this.numUpDown.BackColor = System.Drawing.SystemColors.Control;
            this.numUpDown.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.numUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpDown.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpDown.Location = new System.Drawing.Point(228, 13);
            this.numUpDown.Maximum = new decimal(new int[] {
            140,
            0,
            0,
            0});
            this.numUpDown.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.ReadOnly = true;
            this.numUpDown.Size = new System.Drawing.Size(59, 26);
            this.numUpDown.TabIndex = 0;
            this.numUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // tbText
            // 
            this.tbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbText.Location = new System.Drawing.Point(13, 13);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(209, 179);
            this.tbText.TabIndex = 1;
            this.tbText.TextChanged += new System.EventHandler(this.tbText_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 204);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.numUpDown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.TextBox tbText;
    }
}

