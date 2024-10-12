using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_PTGT
{
    public class XeHoi : PhuongTien, IThongTinThem
    {
        public override void DiChuyen()
        {
            Console.WriteLine($"{TenPhuongTien} đang di chuyển bằng {LoaiNhienLieu}");
        }
        public double TocDoToiDa()
        {
            return 200;
        }
        public double TieuThuNhienLieu()
        {
            return 8;
        }
    }
    public class XeDap : PhuongTien, IThongTinThem 
    {
        public override void DiChuyen() 
        {
            Console.WriteLine($"{TenPhuongTien} đang di chuyển");
        }
        public double TocDoToiDa()
        {
            return 80;
        }
        public double TieuThuNhienLieu()
        {
            throw new NotImplementedException();
        }
    }
}
