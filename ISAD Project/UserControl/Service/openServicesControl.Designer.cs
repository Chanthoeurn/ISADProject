namespace ISAD_Project
{
    partial class openServicesControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSortServices = new System.Windows.Forms.ComboBox();
            this.btnAddServices = new System.Windows.Forms.Button();
            this.btnModifyServices = new System.Windows.Forms.Button();
            this.btnDeleteServices = new System.Windows.Forms.Button();
            this.txtSearchService = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(940, 452);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sort By";
            // 
            // cboSortServices
            // 
            this.cboSortServices.FormattingEnabled = true;
            this.cboSortServices.Location = new System.Drawing.Point(82, 22);
            this.cboSortServices.Name = "cboSortServices";
            this.cboSortServices.Size = new System.Drawing.Size(121, 21);
            this.cboSortServices.TabIndex = 2;
            // 
            // btnAddServices
            // 
            this.btnAddServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnAddServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddServices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnAddServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddServices.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddServices.ForeColor = System.Drawing.Color.White;
            this.btnAddServices.Location = new System.Drawing.Point(372, 21);
            this.btnAddServices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddServices.Name = "btnAddServices";
            this.btnAddServices.Size = new System.Drawing.Size(100, 28);
            this.btnAddServices.TabIndex = 12;
            this.btnAddServices.Text = "Add New";
            this.btnAddServices.UseVisualStyleBackColor = false;
            // 
            // btnModifyServices
            // 
            this.btnModifyServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnModifyServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifyServices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnModifyServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyServices.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyServices.ForeColor = System.Drawing.Color.White;
            this.btnModifyServices.Location = new System.Drawing.Point(491, 21);
            this.btnModifyServices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModifyServices.Name = "btnModifyServices";
            this.btnModifyServices.Size = new System.Drawing.Size(100, 28);
            this.btnModifyServices.TabIndex = 13;
            this.btnModifyServices.Text = "Modify";
            this.btnModifyServices.UseVisualStyleBackColor = false;
            // 
            // btnDeleteServices
            // 
            this.btnDeleteServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnDeleteServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteServices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnDeleteServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteServices.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteServices.ForeColor = System.Drawing.Color.White;
            this.btnDeleteServices.Location = new System.Drawing.Point(599, 20);
            this.btnDeleteServices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteServices.Name = "btnDeleteServices";
            this.btnDeleteServices.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteServices.TabIndex = 14;
            this.btnDeleteServices.Text = "Delete";
            this.btnDeleteServices.UseVisualStyleBackColor = false;
            // 
            // txtSearchService
            // 
            this.txtSearchService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.txtSearchService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchService.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchService.ForeColor = System.Drawing.Color.White;
            this.txtSearchService.Location = new System.Drawing.Point(718, 16);
            this.txtSearchService.Multiline = true;
            this.txtSearchService.Name = "txtSearchService";
            this.txtSearchService.Size = new System.Drawing.Size(236, 29);
            this.txtSearchService.TabIndex = 15;
            this.txtSearchService.TextChanged += new System.EventHandler(this.txtSearchService_TextChanged);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(967, 519);
            this.shapeContainer1.TabIndex = 16;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 718;
            this.lineShape1.X2 = 951;
            this.lineShape1.Y1 = 48;
            this.lineShape1.Y2 = 48;
            // 
            // openServicesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.txtSearchService);
            this.Controls.Add(this.btnDeleteServices);
            this.Controls.Add(this.btnModifyServices);
            this.Controls.Add(this.btnAddServices);
            this.Controls.Add(this.cboSortServices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "openServicesControl";
            this.Size = new System.Drawing.Size(967, 519);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSortServices;
        private System.Windows.Forms.Button btnAddServices;
        private System.Windows.Forms.Button btnModifyServices;
        private System.Windows.Forms.Button btnDeleteServices;
        private System.Windows.Forms.TextBox txtSearchService;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}
