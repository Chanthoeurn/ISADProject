namespace ISAD_Project
{
    partial class FormSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignIn));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(579, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 135);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(551, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign In Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(503, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(503, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(508, 298);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(319, 31);
            this.txtUsername.TabIndex = 4;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1294, 660);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 508;
            this.lineShape1.X2 = 840;
            this.lineShape1.Y1 = 329;
            this.lineShape1.Y2 = 329;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.White;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 508;
            this.lineShape2.X2 = 840;
            this.lineShape2.Y1 = 419;
            this.lineShape2.Y2 = 419;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(508, 384);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(319, 31);
            this.txtPassword.TabIndex = 6;
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblForgotPassword.Location = new System.Drawing.Point(709, 435);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(138, 20);
            this.lblForgotPassword.TabIndex = 7;
            this.lblForgotPassword.Text = "Forgot password?";
            // 
            // btnSignIn
            // 
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSignIn.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(62)))));
            this.btnSignIn.Location = new System.Drawing.Point(579, 491);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(183, 41);
            this.btnSignIn.TabIndex = 8;
            this.btnSignIn.Text = "SIGN IN";
            this.btnSignIn.UseVisualStyleBackColor = true;
            // 
            // formSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1294, 660);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1310, 699);
            this.MinimumSize = new System.Drawing.Size(1310, 699);
            this.Name = "formSignIn";
            this.Text = "formSignIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Button btnSignIn;
    }
}