using System;
using System.Collections.Generic;

namespace ManeskinDomein.Model;

public partial class Tour : Entity
{
    public int TourId { get; set; }

    public int PerfomanceId { get; set; }

    public DateOnly TourBegin { get; set; }

    public DateOnly TourEnd { get; set; }

    public virtual Perfomance Perfomance { get; set; } = null!;
}
