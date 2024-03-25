// Danhmuc gồm Báo, Sách, Tạp chí
using _0338_TruongDinhNhat_LTCS_GK;

List<DanhMuc> listDanhMuc338 = new List<DanhMuc>
{
    new DanhMuc(1, "Sach"),
    new DanhMuc(2, "Bao"),
    new DanhMuc(3, "Tap Chi")
};

List<Sach> listSach338 = new List<Sach>
{
    new Sach("XB01", "Sach 1", "NPH 1", 1, "Nguyen Van A", 200),
    new Sach("XB02", "Sach 2", "NPH 2", 1, "Nguyen Van B", 200)
};

List<Bao> listBao338 = new List<Bao>
{
    new Bao("XB05", "Bao 1", "NPH 3", 2, new DateTime(2024, 3, 15)),
    new Bao("XB01", "Bao 2", "NPH 4", 2, new DateTime(2024, 6, 1))
};

List<TapChi> listTapChi338 = new List<TapChi>
{
    new TapChi("XB03", "Tap Chi 1", "NPH 5", 3, 5, 100),
    new TapChi("XB04", "Tap Chi 2", "NPH 6", 3, 15, 200)
};

List<TaiLieu> listTaiLieu338 = new List<TaiLieu>();
listTaiLieu338.AddRange(listSach338);
listTaiLieu338.AddRange(listBao338);
listTaiLieu338.AddRange(listTapChi338);

// Tìm theo loại (S, B, TC)
Console.Write("Nhap loai: (Sach = 1, Bao = 2, Tap chi = 3): ");
var keyword338 = int.Parse(Console.ReadLine());
var searchByCategoryId338 = listTaiLieu338.Where(tl338 => tl338.CateId == keyword338).ToList();

foreach (var item338 in searchByCategoryId338)
{
    Console.WriteLine($"CateId: {item338.CateId}, TenTL: {item338.TenTL}");
}

// Tìm báo có ngày PH trong tháng 3/2024
Console.WriteLine();
Console.WriteLine("Bao co ngay PH trong thang 3/2024");
var searchByDate338 = listBao338.Where(bao338 => bao338.NgayPH.Month == 3 && bao338.NgayPH.Year == 2024).ToList();

foreach (var item338 in searchByDate338)
{
    Console.WriteLine($"CateId: {item338.CateId}, TenTL: {item338.TenTL}");
}

Console.ReadKey();