using System;
using System.Collections.Generic;

namespace IP007D_SpotifyManager.Models;

public partial class Playlist
{
    public int PlaylistId { get; set; }

    public string PlaylistName { get; set; } = null!;

    public virtual ICollection<Connect> Connect { get; } = new List<Connect>();
}
