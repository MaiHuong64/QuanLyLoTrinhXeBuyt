using QuanLyLoTrinhXeBuyt.Data;
using System;
using System.IO;
using System.Linq;
using System.Text.Json;
public class LuuTruCuonChieu
{
    static void Main(string[] args)
    {
        // Định danh ngày sao lưu
        DateTime ngaySaoLuu = DateTime.Now.AddDays(-7);
        //string backUpFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Backup", "ChuyenXe");
        string backUpFolder = @"D:\Backup\ChuyenXe";

        try
        {
            Directory.CreateDirectory(backUpFolder);
            string jsonPath = Path.Combine(backUpFolder, $"ChuyeXe_{DateTime.Now:dd-MM-yyyy}.json");


            using (var context = new QLLTXBContext())
            {
                var duLieuCu = context.ChuyenXe.Where(d => d.ThoiGianDen.Date < ngaySaoLuu.Date).ToList();
                //Console.WriteLine("----- DỮ LIỆU TỪ DATABASE -----");
                //foreach (var item in duLieuCu)
                //{
                //    Console.WriteLine($"ID: {item.ChuyenXeID}, ThoiGianDen: {item.ThoiGianDen:dd/MM/yyyy HH:mm}");
                //}
                if (!duLieuCu.Any())
                {
                    Console.WriteLine("Không có dữ liệu cần sao lưu");
                    return;
                }
                var danhsach = duLieuCu.Select(c => new DanhSachChuyenXe
                {
                    ChuyenXeID = c.ChuyenXeID,
                    TenChuyen = c.TenChuyen,
                    DiemXuatPhat = c.DiemXuatPhat,
                    ThoiGianDi = c.ThoiGianDi,
                    ThoiGianDen = c.ThoiGianDen,
                    TuyenXeID = c.TuyenXeID,
                    XeID = c.XeID,
                    TenTuyen = c.TuyenXe?.TenTuyen,
                    BienSo = c.Xe?.BienSo
                }).ToList();

                // Ghi file
                var option = new JsonSerializerOptions();
                option.WriteIndented = true; // Xuong dong
                string jsonFile = JsonSerializer.Serialize(danhsach, option);

                File.WriteAllText(jsonPath, jsonFile);

                context.ChuyenXe.RemoveRange(duLieuCu);
                context.SaveChanges();


                Console.WriteLine($"Đã sao lưu và xóa {duLieuCu.Count} bản ghi cũ.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi: {ex.Message}");
        }
    }
}

