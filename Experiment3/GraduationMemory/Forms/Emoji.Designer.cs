namespace Forms
{
    partial class Emoji
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            EmojisToDataGridView = new DataGridView();
            Column1 = new DataGridViewImageColumn();
            Column2 = new DataGridViewImageColumn();
            Column3 = new DataGridViewImageColumn();
            Column4 = new DataGridViewImageColumn();
            Column5 = new DataGridViewImageColumn();
            Column6 = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)EmojisToDataGridView).BeginInit();
            SuspendLayout();
            // 
            // EmojisToDataGridView
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            EmojisToDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            EmojisToDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmojisToDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            EmojisToDataGridView.Location = new Point(0, 0);
            EmojisToDataGridView.Margin = new Padding(0);
            EmojisToDataGridView.Name = "EmojisToDataGridView";
            EmojisToDataGridView.RowHeadersWidth = 51;
            EmojisToDataGridView.RowTemplate.Height = 29;
            EmojisToDataGridView.ScrollBars = ScrollBars.None;
            EmojisToDataGridView.Size = new Size(393, 209);
            EmojisToDataGridView.TabIndex = 0;
            EmojisToDataGridView.CellContentClick += EmojisToDataGridView_CellContentClick_1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Column6";
            Column6.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Emoji
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(393, 209);
            Controls.Add(EmojisToDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Emoji";
            ((System.ComponentModel.ISupportInitialize)EmojisToDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView EmojisToDataGridView;
        private DataGridViewImageColumn Column1;
        private DataGridViewImageColumn Column2;
        private DataGridViewImageColumn Column3;
        private DataGridViewImageColumn Column4;
        private DataGridViewImageColumn Column5;
        private DataGridViewImageColumn Column6;
    }
}