using System;
using System.Collections.Generic;

namespace ManeskinDomein.Model;

public partial class Song : Entity
{
    public int SongId { get; set; }

    public string Tittle { get; set; } = null!;

    public int AlbumId { get; set; }

    public string? Duration { get; set; }

    public DateOnly DataRelease { get; set; }

    public virtual Albumss Album { get; set; } = null!;

    public virtual ICollection<Clip> Clips { get; set; } = new List<Clip>();
}
