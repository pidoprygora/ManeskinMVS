using System;
using System.Collections.Generic;

namespace ManeskinDomein.Model;

public partial class Location : Entity
{
    public int LocationId { get; set; }

    public string? Country { get; set; }

    public string City { get; set; } = null!;

    public virtual ICollection<Festival> Festivals { get; set; } = new List<Festival>();

    public virtual ICollection<Perfomance> Perfomances { get; set; } = new List<Perfomance>();
}
