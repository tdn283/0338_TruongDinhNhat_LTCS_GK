using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0338_TruongDinhNhat_LTCS_GK
{
    public class TapChi : TaiLieu
    {
        public int SoPH { get; set; }
        public int TrangPH { get; set; }
        public TapChi(string maXB, string tenTL, string nhaPhatHanh, int cateId, int soPH, int trangPH) : base(maXB, tenTL, nhaPhatHanh, cateId)
        {
            SoPH = soPH;
            TrangPH = trangPH;
        }
    }
}
