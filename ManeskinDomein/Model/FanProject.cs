using System;
using System.Collections.Generic;

namespace ManeskinDomein.Model;

public partial class FanProject : Entity
{
    public int ProjectId { get; set; }

    public int PerfomanceId { get; set; }

    public string ProjectName { get; set; } = null!;

    public DateOnly Date { get; set; }

    public virtual Perfomance Perfomance { get; set; } = null!;
}
