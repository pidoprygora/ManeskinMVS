using System;
using System.Collections.Generic;

namespace ManeskinDomein.Model;

public partial class Albumss : Entity
{
    public int AlbumId { get; set; }

    public string Tittle { get; set; } = null!;

    public DateOnly YearRelease { get; set; }

    public int Length { get; set; }

    public virtual ICollection<Song> Songs { get; set; } = new List<Song>();
}
