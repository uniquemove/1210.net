using QL_PTGT;
using System.Text;

public class Program
{
    public static void Main(String[] args)
    {
        List<PhuongTien> list = new List<PhuongTien>();
        Console.OutputEncoding = Encoding.UTF8;
        XeHoi xeHoi = new XeHoi
        {
            TenPhuongTien = "Xe Hơi Toyota",
            LoaiNhienLieu = "Xăng"
        };
        list.Add(xeHoi);
        XeDap xeDap = new XeDap
        {
            TenPhuongTien = "Xe Đạp Martin",
            LoaiNhienLieu = "Không"
        };
        list.Add(xeDap);
        foreach (PhuongTien i in list)
        {
            i.DiChuyen();
            if (i is IThongTinThem thongTinThem)
            {
                Console.WriteLine($"Tốc độ tối đa: {thongTinThem.TocDoToiDa()} km/h");

                try
                {
                    Console.WriteLine($"Mức tiêu thụ nhiên liệu: {thongTinThem.TieuThuNhienLieu()} lít/100km");
                }
                catch (NotImplementedException)
                {
                    break;
                }
            }

            Console.WriteLine();  // Xuống dòng giữa các phương tiện

        }
    }
}