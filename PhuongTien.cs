using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_PTGT
{
    public abstract class PhuongTien
    {
        public String TenPhuongTien { get; set; }
        public String LoaiNhienLieu { get; set; }

        public abstract void DiChuyen();     
    }

}
