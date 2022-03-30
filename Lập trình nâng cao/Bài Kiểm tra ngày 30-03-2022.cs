using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace BaiTap {
  
  public static class Program {
    public static void Main(string[] args) {
      // Đề bài: đọc file data.csv
      // a) tính tổng các số chẵn
      // b) đếm các số chia hết cho 7
      // c) xuất 2 hàng đầu ra file output.txt
      StreamReader Data = new StreamReader("data.csv");
      StreamWriter ouputData = new StreamWriter("output.txt");
      
      int tongSoChan = 0; // tổng số chẵn
      int soChiaHetCho7 = 0; // đếm số chia hết cho 7
      int countLine = 0; // đếm số dòng đã lặp

      string line;
      
      while ((line = Data.ReadLine()) != null) {
        // Câu c
        countLine++; // cộng 1 mỗi lần lặp 1 dòng
        if (countLine <= 2) ouputData.WriteLine(line); // nếu lặp dòng <= 2 thì viết thêm nội dung của dòng vào file output.txt
        if (countLine == 2) ouputData.Close(); // nếu dòng == 2 thì đóng file output;
        
        // câu a & b
        string[] numbers = line.Split(',');
        foreach (string num in numbers) {
          int number = int.Parse(num);
          if (number % 2 == 0) tongSoChan += number; // nếu chia hết cho 2 thì cộng vào tổng số chẵn
          if (number % 7 == 0) soChiaHetCho7++; // nếu chia hết cho 7 thì cộng 1 vào biến đếm chia hết cho 7
        }
      }
      Data.Close(); // đóng file data.csv
      Console.WriteLine($"Tong so chan: {tongSoChan}");
      Console.WriteLine($"Tong so chia het cho 7: {soChiaHetCho7}");
      // đã lưu file output.txt 
    }
  }
}
