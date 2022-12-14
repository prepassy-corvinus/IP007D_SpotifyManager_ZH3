using System;
using System.Collections.Generic;

namespace IP007D_SpotifyManager.Models;

public partial class Connect
{
    public int ConnectId { get; set; }

    public int PlaylistFk { get; set; }

    public int SongFk { get; set; }

    public virtual Playlist PlaylistFkNavigation { get; set; } = null!;

    public virtual Song SongFkNavigation { get; set; } = null!;
}
