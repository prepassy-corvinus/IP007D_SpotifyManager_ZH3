using IP007D_SpotifyManager.Models;
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
    public partial class SongsUC : UserControl
    {
        SE22Context context = new SE22Context();

        public SongsUC()
        {
            InitializeComponent();
            songBindingSource.DataSource = context.Song.ToList();
        }
    }
}
