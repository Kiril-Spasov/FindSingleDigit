namespace FindSingleDigit
{
    partial class FormFindSingleDigit
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
            this.BtnCalculateSignleDigit = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCalculateSignleDigit
            // 
            this.BtnCalculateSignleDigit.Location = new System.Drawing.Point(39, 43);
            this.BtnCalculateSignleDigit.Name = "BtnCalculateSignleDigit";
            this.BtnCalculateSignleDigit.Size = new System.Drawing.Size(180, 63);
            this.BtnCalculateSignleDigit.TabIndex = 0;
            this.BtnCalculateSignleDigit.Text = "Calculate Single Digit";
            this.BtnCalculateSignleDigit.UseVisualStyleBackColor = true;
            this.BtnCalculateSignleDigit.Click += new System.EventHandler(this.BtnCalculateSignleDigit_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(245, 43);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(484, 357);
            this.TxtResult.TabIndex = 1;
            // 
            // FormFindSingleDigit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnCalculateSignleDigit);
            this.Name = "FormFindSingleDigit";
            this.Text = "Find The Single Digit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalculateSignleDigit;
        private System.Windows.Forms.TextBox TxtResult;
    }
}

