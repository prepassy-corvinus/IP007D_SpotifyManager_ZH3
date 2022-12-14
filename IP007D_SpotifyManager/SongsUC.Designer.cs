namespace IP007D_SpotifyManager
{
    partial class SongsUC
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.songBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.songIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bpmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.songIdDataGridViewTextBoxColumn,
            this.trackDataGridViewTextBoxColumn,
            this.artistDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.bpmDataGridViewTextBoxColumn,
            this.connectDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.songBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(634, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // songBindingSource
            // 
            this.songBindingSource.DataSource = typeof(IP007D_SpotifyManager.Models.Song);
            // 
            // songIdDataGridViewTextBoxColumn
            // 
            this.songIdDataGridViewTextBoxColumn.DataPropertyName = "SongId";
            this.songIdDataGridViewTextBoxColumn.HeaderText = "SongId";
            this.songIdDataGridViewTextBoxColumn.Name = "songIdDataGridViewTextBoxColumn";
            // 
            // trackDataGridViewTextBoxColumn
            // 
            this.trackDataGridViewTextBoxColumn.DataPropertyName = "Track";
            this.trackDataGridViewTextBoxColumn.HeaderText = "Track";
            this.trackDataGridViewTextBoxColumn.Name = "trackDataGridViewTextBoxColumn";
            // 
            // artistDataGridViewTextBoxColumn
            // 
            this.artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
            this.artistDataGridViewTextBoxColumn.HeaderText = "Artist";
            this.artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // bpmDataGridViewTextBoxColumn
            // 
            this.bpmDataGridViewTextBoxColumn.DataPropertyName = "Bpm";
            this.bpmDataGridViewTextBoxColumn.HeaderText = "Bpm";
            this.bpmDataGridViewTextBoxColumn.Name = "bpmDataGridViewTextBoxColumn";
            // 
            // connectDataGridViewTextBoxColumn
            // 
            this.connectDataGridViewTextBoxColumn.DataPropertyName = "Connect";
            this.connectDataGridViewTextBoxColumn.HeaderText = "Connect";
            this.connectDataGridViewTextBoxColumn.Name = "connectDataGridViewTextBoxColumn";
            this.connectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SongsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "SongsUC";
            this.Size = new System.Drawing.Size(640, 356);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn songIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn trackDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bpmDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn connectDataGridViewTextBoxColumn;
        private BindingSource songBindingSource;
    }
}
