
namespace Job_Applications
{
    partial class activejobs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(activejobs));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.jobsgdv = new Guna.UI.WinForms.GunaDataGridView();
            this.createbtn = new ns1.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobsgdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(304, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 77);
            this.label2.TabIndex = 6;
            this.label2.Text = "Active Jobs";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 75);
            this.panel1.TabIndex = 1;
            // 
            // jobsgdv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.jobsgdv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.jobsgdv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jobsgdv.BackgroundColor = System.Drawing.Color.White;
            this.jobsgdv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jobsgdv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.jobsgdv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jobsgdv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.jobsgdv.ColumnHeadersHeight = 25;
            this.jobsgdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.jobsgdv.DefaultCellStyle = dataGridViewCellStyle3;
            this.jobsgdv.EnableHeadersVisualStyles = false;
            this.jobsgdv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.jobsgdv.Location = new System.Drawing.Point(12, 89);
            this.jobsgdv.Name = "jobsgdv";
            this.jobsgdv.RowHeadersVisible = false;
            this.jobsgdv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jobsgdv.Size = new System.Drawing.Size(979, 466);
            this.jobsgdv.TabIndex = 2;
            this.jobsgdv.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.jobsgdv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.jobsgdv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.jobsgdv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.jobsgdv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.jobsgdv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.jobsgdv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.jobsgdv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.jobsgdv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.jobsgdv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.jobsgdv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.jobsgdv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.jobsgdv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.jobsgdv.ThemeStyle.HeaderStyle.Height = 25;
            this.jobsgdv.ThemeStyle.ReadOnly = false;
            this.jobsgdv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.jobsgdv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.jobsgdv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.jobsgdv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.jobsgdv.ThemeStyle.RowsStyle.Height = 22;
            this.jobsgdv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.jobsgdv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.jobsgdv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // createbtn
            // 
            this.createbtn.ActiveBorderThickness = 1;
            this.createbtn.ActiveCornerRadius = 20;
            this.createbtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.createbtn.ActiveForecolor = System.Drawing.Color.White;
            this.createbtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.createbtn.BackColor = System.Drawing.SystemColors.Control;
            this.createbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createbtn.BackgroundImage")));
            this.createbtn.ButtonText = "Apply";
            this.createbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createbtn.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.createbtn.IdleBorderThickness = 1;
            this.createbtn.IdleCornerRadius = 20;
            this.createbtn.IdleFillColor = System.Drawing.Color.Blue;
            this.createbtn.IdleForecolor = System.Drawing.Color.White;
            this.createbtn.IdleLineColor = System.Drawing.Color.Blue;
            this.createbtn.Location = new System.Drawing.Point(996, 275);
            this.createbtn.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(121, 55);
            this.createbtn.TabIndex = 34;
            this.createbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1009, 342);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // activejobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 567);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.createbtn);
            this.Controls.Add(this.jobsgdv);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "activejobs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "activejobs";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobsgdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView jobsgdv;
        private ns1.BunifuThinButton2 createbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}