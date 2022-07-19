namespace BrancingPractice
{
    partial class Form1
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
            this.btnDisplayGreeting = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDisplayGreeting
            // 
            this.btnDisplayGreeting.Location = new System.Drawing.Point(68, 158);
            this.btnDisplayGreeting.Name = "btnDisplayGreeting";
            this.btnDisplayGreeting.Size = new System.Drawing.Size(165, 117);
            this.btnDisplayGreeting.TabIndex = 0;
            this.btnDisplayGreeting.Text = "Display Greeting";
            this.btnDisplayGreeting.UseVisualStyleBackColor = true;
            this.btnDisplayGreeting.Click += new System.EventHandler(this.BtnDisplayGreeting_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(33, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(225, 43);
            this.txtName.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 386);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnDisplayGreeting);
            this.Name = "Form1";
            this.Text = "Brancing Practice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDisplayGreeting;
        private TextBox txtName;
    }
}