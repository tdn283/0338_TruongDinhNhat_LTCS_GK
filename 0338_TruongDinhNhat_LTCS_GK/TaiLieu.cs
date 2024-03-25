using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0338_TruongDinhNhat_LTCS_GK
{
    public class TaiLieu
    {
        public string MaXB { get; set; }
        public string TenTL { get; set; }
        public string NhaPhatHanh { get; set; }
        public int CateId { get; set; }
        public TaiLieu(string maXB, string tenTL, string nhaPhatHanh, int cateId)
        {
            MaXB = maXB;
            TenTL = tenTL;
            NhaPhatHanh = nhaPhatHanh;
            CateId = cateId;
        }
    }
}
