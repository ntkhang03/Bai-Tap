using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BaiTap {
  
  public static class Program {
    public static void Main(string[] args) {
      // Đề bài: đọc file blog.txt và xuất ra tất cả hashTag vào file Hashtag.txt
      StreamReader baiBao = new StreamReader("blog.txt");
      StreamWriter writeHashtag = new StreamWriter("Hashtag.txt");
      string line;
      
      while ((line = baiBao.ReadLine()) != null) {
        string[] splitLine = line.Split(' '); // tách chuỗi bằng ký tự khoảng cách
        foreach (string hashTag in splitLine) // foreach duyệt từng phần tử của mảng, tài liệu tham khảo: https://howkteam.vn/course/khoa-hoc-lap-trinh-c-can-ban/vong-lap-foreach-trong-lap-trinh-c-co-ban-1193
        
          // dùng foreach + IndexOf tìm hashtag trong hàng
          if (hashTag.IndexOf('#') == 0) writeHashtag.WriteLine(hashTag); // nếu có ký tự # đứng ở vị trí đầu tiên => là hashTag => viết vào file
      }
	    
      writeHashtag.Close();
      baiBao.Close();
      Console.WriteLine("Đã lưu tất cả các hashTag vào file Hashtag.txt");
	    
    }
  }
}
