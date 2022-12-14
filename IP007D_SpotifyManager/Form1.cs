namespace IP007D_SpotifyManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEditor_Click(object sender, EventArgs e)
        {
            EditorUC uc = new EditorUC();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void buttonCreator_Click(object sender, EventArgs e)
        {

            CreatorUC uc = new CreatorUC();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void buttonSongs_Click(object sender, EventArgs e)
        {

            SongsUC uc = new SongsUC();
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("All unsaved changes will be lost", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}