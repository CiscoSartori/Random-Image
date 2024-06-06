using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmap_Image
{
 internal class Class1
 {
  private Bitmap bmp;
  private int generatedImgs;
  private string[] paths;
  private readonly static Random rnd = new Random();

  public Bitmap getImg()
  {
   //if (bmp[generatedImg] == null)
   //{
    this.bmp = new Bitmap(file_Path());
  // }

    return this.bmp;
  }
  public Bitmap backImg()
  {
   //if (bmp[generatedImg] == null)
   //{
   this.bmp = new Bitmap(this.paths[this.generatedImgs]);
   // }

   return this.bmp;
  }

  private string file_Path()
  {

   string[] filePaths = Directory.GetFiles(@"G:\Programas\ㅤ\Octopath Traveler");
   int maxf = rnd.Next(filePaths.Length);
   string filePath = filePaths[maxf];
   var extension = Path.GetExtension(filePath).ToLower();


   if (extension == ".mp4")
   {
    filePath = file_Path();
   }

   //this.generatedImgs = 1;
   //this.paths[this.generatedImgs] = filePath;
   return filePath;
  }
 }
}
