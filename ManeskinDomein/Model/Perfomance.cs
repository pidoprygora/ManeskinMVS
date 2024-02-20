using System;
using System.Collections.Generic;

namespace ManeskinDomein.Model;

public partial class Perfomance : Entity
{
    public int PerfomanceId { get; set; }

    public int LocationId { get; set; }

    public DateOnly Date { get; set; }

    public string? Information { get; set; }

    public virtual ICollection<FanProject> FanProjects { get; set; } = new List<FanProject>();

    public virtual Location Location { get; set; } = null!;

    public virtual ICollection<Tour> Tours { get; set; } = new List<Tour>();
}
