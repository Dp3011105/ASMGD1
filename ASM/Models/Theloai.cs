using System;
using System.Collections.Generic;

namespace ASM.Models;

public partial class Theloai
{
    public int MaTheloai { get; set; }

    public string? TenTheloai { get; set; }

    public virtual ICollection<Sach> Saches { get; set; } = new List<Sach>();
}
