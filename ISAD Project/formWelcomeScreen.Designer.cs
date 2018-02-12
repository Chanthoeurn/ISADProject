namespace ISAD_Project
{
    partial class FormWelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWelcomeScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(505, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 271);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.label1.Font = new System.Drawing.Font("Ubuntu", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(433, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "BCS Computer Management System";
            // 
            // btnGetStart
            // 
            this.btnGetStart.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(62)))));
            this.btnGetStart.Location = new System.Drawing.Point(527, 457);
            this.btnGetStart.Name = "btnGetStart";
            this.btnGetStart.Size = new System.Drawing.Size(211, 54);
            this.btnGetStart.TabIndex = 2;
            this.btnGetStart.Text = "GET START";
            this.btnGetStart.UseVisualStyleBackColor = true;
            // 
            // formWelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1294, 660);
            this.Controls.Add(this.btnGetStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1310, 699);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1310, 699);
            this.Name = "formWelcomeScreen";
            this.Text = "formWelcomeScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetStart;
    }
}