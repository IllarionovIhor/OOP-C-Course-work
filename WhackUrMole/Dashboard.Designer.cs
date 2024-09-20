namespace WhackUrMole
{
    partial class Dashboard
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
            this.RecordsTable = new System.Windows.Forms.DataGridView();
            this.difficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // RecordsTable
            // 
            this.RecordsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.score,
            this.difficulty});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RecordsTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.RecordsTable.Location = new System.Drawing.Point(12, 12);
            this.RecordsTable.Name = "RecordsTable";
            this.RecordsTable.RowHeadersVisible = false;
            this.RecordsTable.RowHeadersWidth = 51;
            this.RecordsTable.RowTemplate.Height = 24;
            this.RecordsTable.Size = new System.Drawing.Size(844, 426);
            this.RecordsTable.TabIndex = 0;
            this.RecordsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // difficulty
            // 
            this.difficulty.Frozen = true;
            this.difficulty.HeaderText = "Складність";
            this.difficulty.MinimumWidth = 6;
            this.difficulty.Name = "difficulty";
            this.difficulty.ReadOnly = true;
            this.difficulty.Width = 125;
            // 
            // score
            // 
            this.score.Frozen = true;
            this.score.HeaderText = "Рекорд";
            this.score.MinimumWidth = 6;
            this.score.Name = "score";
            this.score.ReadOnly = true;
            this.score.Width = 125;
            // 
            // username
            // 
            this.username.Frozen = true;
            this.username.HeaderText = "Ім\'я гравця";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 125;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.RecordsTable);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RecordsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RecordsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.DataGridViewTextBoxColumn difficulty;
    }
}