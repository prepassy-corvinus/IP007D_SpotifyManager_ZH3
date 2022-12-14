namespace IP007D_SpotifyManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEditor = new System.Windows.Forms.Button();
            this.buttonCreator = new System.Windows.Forms.Button();
            this.buttonSongs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 589);
            this.panel1.TabIndex = 0;
            // 
            // buttonEditor
            // 
            this.buttonEditor.Location = new System.Drawing.Point(12, 12);
            this.buttonEditor.Name = "buttonEditor";
            this.buttonEditor.Size = new System.Drawing.Size(75, 23);
            this.buttonEditor.TabIndex = 0;
            this.buttonEditor.Text = "Editor";
            this.buttonEditor.UseVisualStyleBackColor = true;
            this.buttonEditor.Click += new System.EventHandler(this.buttonEditor_Click);
            // 
            // buttonCreator
            // 
            this.buttonCreator.Location = new System.Drawing.Point(93, 12);
            this.buttonCreator.Name = "buttonCreator";
            this.buttonCreator.Size = new System.Drawing.Size(75, 23);
            this.buttonCreator.TabIndex = 1;
            this.buttonCreator.Text = "Creator";
            this.buttonCreator.UseVisualStyleBackColor = true;
            this.buttonCreator.Click += new System.EventHandler(this.buttonCreator_Click);
            // 
            // buttonSongs
            // 
            this.buttonSongs.Location = new System.Drawing.Point(174, 12);
            this.buttonSongs.Name = "buttonSongs";
            this.buttonSongs.Size = new System.Drawing.Size(75, 23);
            this.buttonSongs.TabIndex = 2;
            this.buttonSongs.Text = "Songs";
            this.buttonSongs.UseVisualStyleBackColor = true;
            this.buttonSongs.Click += new System.EventHandler(this.buttonSongs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 642);
            this.Controls.Add(this.buttonEditor);
            this.Controls.Add(this.buttonCreator);
            this.Controls.Add(this.buttonSongs);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonEditor;
        private Button buttonCreator;
        private Button buttonSongs;
    }
}