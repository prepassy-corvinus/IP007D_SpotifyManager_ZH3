using System;
using System.Collections.Generic;

namespace IP007D_SpotifyManager.Models;

public partial class Song
{
    public int SongId { get; set; }

    public string Track { get; set; } = null!;

    public string? Artist { get; set; }

    public string? Genre { get; set; }

    public int? Bpm { get; set; }

    public virtual ICollection<Connect> Connect { get; } = new List<Connect>();
}
