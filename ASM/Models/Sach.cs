using System;
using System.Collections.Generic;

namespace ASM.Models;

public partial class Sach
{
    public int MaSach { get; set; }

    public string? TenSach { get; set; }

    public string? TacGia { get; set; }

    public int? MaTheloai { get; set; }

    public string? Nxb { get; set; }

    public int? NamXuatBan { get; set; }

    public virtual Theloai? MaTheloaiNavigation { get; set; }
}
