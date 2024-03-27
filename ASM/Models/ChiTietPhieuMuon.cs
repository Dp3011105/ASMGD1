using System;
using System.Collections.Generic;

namespace ASM.Models;

public partial class ChiTietPhieuMuon
{
    public int? MaPhieu { get; set; }

    public int? MaSach { get; set; }

    public int? SoLuong { get; set; }

    public virtual PhieuMuon? MaPhieuNavigation { get; set; }

    public virtual Sach? MaSachNavigation { get; set; }
}
