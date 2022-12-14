using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP007D_SpotifyManager
{
    public partial class NewPlaylistForm : Form
    {
        public NewPlaylistForm()
        {
            InitializeComponent();
            errorProvider1 = new ErrorProvider();
        }

        private void textBoxPass_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxPass, "");
            buttonAdd.Enabled = true;
        }

        private void textBoxPlaylist_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxPlaylist, "");
            buttonAdd.Enabled = true;
        }

        private void textBoxPlaylist_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPlaylist.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxPlaylist, "The playlist name cannot be empty!");
            }
        }

        private void textBoxPass_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPass.Text != "Yes123")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxPass, "Type 'Yes123' to continue!");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
            Close();
        }
    }
}
