using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Bitmap_Image;

namespace Random_Image
{
 public partial class Form1 : Form
 {
  public Form1()
  {
   InitializeComponent();
  }
  Class1 novo = new Class1();
  private void right_Click(object sender, EventArgs e)
  {
   this.BackgroundImage = novo.getImg() ;
  }

  private void left_Click(object sender, EventArgs e)
  {
   //this.BackgroundImage = new Bitmap(file_Path());
   this.BackgroundImage = novo.backImg();
  }

  private void Form1_Load(object sender, EventArgs e)
  {

  }

 }
}
