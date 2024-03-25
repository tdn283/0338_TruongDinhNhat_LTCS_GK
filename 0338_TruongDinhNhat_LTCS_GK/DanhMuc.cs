using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0338_TruongDinhNhat_LTCS_GK
{
    public class DanhMuc
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DanhMuc(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
