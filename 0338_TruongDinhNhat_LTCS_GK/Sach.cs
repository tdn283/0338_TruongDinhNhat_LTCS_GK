using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0338_TruongDinhNhat_LTCS_GK
{
    public class Sach : TaiLieu
    {
        public string TenTG { get; set; }
        public int SoTrang { get; set; }
        public Sach(string maXB, string tenTL, string nhaPhatHanh, int cateId, string tenTG, int soTrang) : base(maXB, tenTL, nhaPhatHanh, cateId)
        {
            TenTG = tenTG;
            SoTrang = soTrang;
        }
    }
}
