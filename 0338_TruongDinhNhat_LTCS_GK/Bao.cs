using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0338_TruongDinhNhat_LTCS_GK
{
    public class Bao : TaiLieu
    {
        public DateTime NgayPH { get; set; }
        public Bao(string maXB, string tenTL, string nhaPhatHanh, int cateId, DateTime ngayPH) : base(maXB, tenTL, nhaPhatHanh, cateId)
        {
            NgayPH = ngayPH;
        }
    }
}
