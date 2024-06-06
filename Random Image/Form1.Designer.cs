using System.Windows.Forms;

namespace Random_Image
{
 partial class Form1
 {
  /// <summary>
  /// Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  /// Clean up any resources being used.
  /// </summary>
  /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
  protected override void Dispose(bool disposing)
  {
   if (disposing && (components != null))
   {
    components.Dispose();
   }
   base.Dispose(disposing);
  }

  #region Windows Form Designer generated code

  /// <summary>
  /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent()
  {
   System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
   this.Right = new System.Windows.Forms.Button();
   this.Left = new System.Windows.Forms.Button();
   this.SuspendLayout();
   // 
   // Right
   // 
   this.Right.BackColor = System.Drawing.Color.Transparent;
   this.Right.Dock = System.Windows.Forms.DockStyle.Right;
   this.Right.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
   this.Right.Location = new System.Drawing.Point(1060, 0);
   this.Right.Margin = new System.Windows.Forms.Padding(0);
   this.Right.Name = "Right";
   this.Right.Size = new System.Drawing.Size(116, 664);
   this.Right.TabIndex = 0;
   this.Right.Text = "-->";
   this.Right.UseVisualStyleBackColor = false;
   this.Right.Click += new System.EventHandler(this.right_Click);
   // 
   // Left
   // 
   this.Left.BackColor = System.Drawing.Color.Transparent;
   this.Left.Dock = System.Windows.Forms.DockStyle.Left;
   this.Left.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
   this.Left.Location = new System.Drawing.Point(0, 0);
   this.Left.Margin = new System.Windows.Forms.Padding(0);
   this.Left.Name = "Left";
   this.Left.Size = new System.Drawing.Size(116, 664);
   this.Left.TabIndex = 1;
   this.Left.Text = "<--";
   this.Left.UseVisualStyleBackColor = false;
   this.Left.Click += new System.EventHandler(this.left_Click);
   // 
   // Form1
   // 
   this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.BackgroundImage = global::Random_Image.Properties.Resources.OIP;
   this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
   this.ClientSize = new System.Drawing.Size(1176, 664);
   this.Controls.Add(this.Left);
   this.Controls.Add(this.Right);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
   this.Name = "Form1";
   this.Text = "Form1";
   this.Load += new System.EventHandler(this.Form1_Load);
   this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.Button Right;
  private System.Windows.Forms.Button Left;
 }
}

