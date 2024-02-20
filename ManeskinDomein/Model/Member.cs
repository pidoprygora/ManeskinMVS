using System;
using System.Collections.Generic;

namespace ManeskinDomein.Model;

public partial class Member : Entity
{
    public int MemberId { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly Age { get; set; }

    public string Instrument { get; set; } = null!;
}
