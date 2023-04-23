namespace Multi_forms
{
    partial class sign_in
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
            this.button1 = new System.Windows.Forms.Button();
            this.us = new System.Windows.Forms.Label();
            this.pa = new System.Windows.Forms.Label();
            this.un = new System.Windows.Forms.TextBox();
            this.pw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(286, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 104);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // us
            // 
            this.us.AutoSize = true;
            this.us.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.us.Location = new System.Drawing.Point(130, 102);
            this.us.Name = "us";
            this.us.Size = new System.Drawing.Size(136, 29);
            this.us.TabIndex = 3;
            this.us.Text = "Username :";
            // 
            // pa
            // 
            this.pa.AutoSize = true;
            this.pa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pa.Location = new System.Drawing.Point(130, 156);
            this.pa.Name = "pa";
            this.pa.Size = new System.Drawing.Size(138, 29);
            this.pa.TabIndex = 4;
            this.pa.Text = "Password  :";
            // 
            // un
            // 
            this.un.Location = new System.Drawing.Point(286, 102);
            this.un.Multiline = true;
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(164, 29);
            this.un.TabIndex = 5;
            // 
            // pw
            // 
            this.pw.Location = new System.Drawing.Point(286, 156);
            this.pw.Multiline = true;
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(164, 29);
            this.pw.TabIndex = 6;
            // 
            // sign_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.un);
            this.Controls.Add(this.pa);
            this.Controls.Add(this.us);
            this.Controls.Add(this.button1);
            this.Name = "sign_in";
            this.Text = "sign_in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label us;
        private System.Windows.Forms.Label pa;
        private System.Windows.Forms.TextBox un;
        private System.Windows.Forms.TextBox pw;
    }
}