namespace IP007D_SpotifyManager
{
    partial class EditorUC
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
            this.listBoxPlaylist = new System.Windows.Forms.ListBox();
            this.listBoxSong = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.connectionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxSong = new System.Windows.Forms.TextBox();
            this.textBoxPlaylist = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPlaylist
            // 
            this.listBoxPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxPlaylist.FormattingEnabled = true;
            this.listBoxPlaylist.ItemHeight = 15;
            this.listBoxPlaylist.Location = new System.Drawing.Point(3, 32);
            this.listBoxPlaylist.Name = "listBoxPlaylist";
            this.listBoxPlaylist.Size = new System.Drawing.Size(236, 484);
            this.listBoxPlaylist.TabIndex = 0;
            this.listBoxPlaylist.SelectedIndexChanged += new System.EventHandler(this.listBoxPlaylist_SelectedIndexChanged);
            // 
            // listBoxSong
            // 
            this.listBoxSong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSong.FormattingEnabled = true;
            this.listBoxSong.ItemHeight = 15;
            this.listBoxSong.Location = new System.Drawing.Point(694, 29);
            this.listBoxSong.Name = "listBoxSong";
            this.listBoxSong.Size = new System.Drawing.Size(236, 469);
            this.listBoxSong.TabIndex = 1;
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
            this.connectionIdDataGridViewTextBoxColumn,
            this.trackDataGridViewTextBoxColumn,
            this.artistDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.connectionDetailBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(245, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(443, 489);
            this.dataGridView1.TabIndex = 2;
            // 
            // connectionIdDataGridViewTextBoxColumn
            // 
            this.connectionIdDataGridViewTextBoxColumn.DataPropertyName = "ConnectionId";
            this.connectionIdDataGridViewTextBoxColumn.HeaderText = "ConnectionId";
            this.connectionIdDataGridViewTextBoxColumn.Name = "connectionIdDataGridViewTextBoxColumn";
            this.connectionIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trackDataGridViewTextBoxColumn
            // 
            this.trackDataGridViewTextBoxColumn.DataPropertyName = "Track";
            this.trackDataGridViewTextBoxColumn.HeaderText = "Track";
            this.trackDataGridViewTextBoxColumn.Name = "trackDataGridViewTextBoxColumn";
            this.trackDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // artistDataGridViewTextBoxColumn
            // 
            this.artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
            this.artistDataGridViewTextBoxColumn.HeaderText = "Artist";
            this.artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
            this.artistDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // connectionDetailBindingSource
            // 
            this.connectionDetailBindingSource.DataSource = typeof(IP007D_SpotifyManager.ConnectionDetail);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(774, 509);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Location = new System.Drawing.Point(855, 509);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // textBoxSong
            // 
            this.textBoxSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSong.Location = new System.Drawing.Point(694, 3);
            this.textBoxSong.Name = "textBoxSong";
            this.textBoxSong.Size = new System.Drawing.Size(236, 23);
            this.textBoxSong.TabIndex = 5;
            this.textBoxSong.TextChanged += new System.EventHandler(this.textBoxSong_TextChanged);
            // 
            // textBoxPlaylist
            // 
            this.textBoxPlaylist.Location = new System.Drawing.Point(3, 3);
            this.textBoxPlaylist.Name = "textBoxPlaylist";
            this.textBoxPlaylist.Size = new System.Drawing.Size(236, 23);
            this.textBoxPlaylist.TabIndex = 6;
            this.textBoxPlaylist.TextChanged += new System.EventHandler(this.textBoxPlaylist_TextChanged);
            // 
            // EditorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxPlaylist);
            this.Controls.Add(this.textBoxSong);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBoxSong);
            this.Controls.Add(this.listBoxPlaylist);
            this.Name = "EditorUC";
            this.Size = new System.Drawing.Size(933, 535);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionDetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxPlaylist;
        private ListBox listBoxSong;
        private DataGridView dataGridView1;
        private Button buttonAdd;
        private Button buttonRemove;
        private TextBox textBoxSong;
        private TextBox textBoxPlaylist;
        private DataGridViewTextBoxColumn connectionIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn trackDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private BindingSource connectionDetailBindingSource;
    }
}
