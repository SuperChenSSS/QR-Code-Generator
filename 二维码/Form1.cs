using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;
using System.IO;

namespace 二维码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filepath = "";

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("陈梦杨出品o(≧v≦)o~~好棒","关于",MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void 生成模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Text = "生成";
            textBox1.Text = "";
        }

        private void 识别模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Text = "识别";
            pictureBox1.Image = null;
            textBox1.Text = "识别文本在此显示";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "生成")
            {
                if (textBox1.Text.Trim() != "")
                {
                    string enCodeString = textBox1.Text;
                    QRCodeEncoder QRCodeEncoder = new QRCodeEncoder();
                    pictureBox1.Image = QRCodeEncoder.Encode(enCodeString,
                                                            Encoding.UTF8);
                }
                else
                {
                    MessageBox.Show("请输入内容：");
                }
            }
            else if(button1.Text=="识别")//识别代码
	        {
                OpenFileDialog p = new OpenFileDialog();
                p.Title = "请选择二维码文件";
                p.Filter = "图片文件(*.jpg)|*.jpg";
                p.Multiselect = false;
                if (p.ShowDialog() == DialogResult.OK)
                {
                    filepath = p.FileName;
                    System.Threading.Thread t = new System.Threading.Thread(ss);
                    t.IsBackground = true;
                    t.Start();
                }
	        }
            else
            {
                MessageBox.Show("请选择模式","错误!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ss()
        {
            if (filepath != "")
            {
                string tt = "";
                try
                {
                    Invoke((EventHandler)delegate
                    {
                        button1.Enabled = false;
                        button1.Text = "Waiting!";
                        pictureBox1.Image = new Bitmap(filepath);
                    });
                    /*pictureBox1.Size = new Size(new Bitmap(filepath).Size.Width,
                        new Bitmap(filepath).Size.Height);*/
                    QRCodeDecoder qrDecoder = new QRCodeDecoder();
                    string txtMsg = qrDecoder.decode(new QRCodeBitmapImage(
                        new Bitmap(pictureBox1.Image)), Encoding.UTF8);
                    tt = txtMsg;
                }
                catch(Exception) 
                {
                    tt = "识别失败";
                }
                Invoke((EventHandler)delegate
                {
                    button1.Enabled = true;
                    textBox1.Text = tt;
                    button1.Text = "识别";
                });
            }
            System.Threading.Thread.CurrentThread.Abort();
        }
        private void 二维码另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
                    if (pictureBox1.Image!=null)
        {
	        try
	                    {
	                        SaveFileDialog saveDlg = new SaveFileDialog();//让用户指定文件的路径名
	                        saveDlg.Filter = "图片文件(*.jpg)|*.jpg";
	                        if (saveDlg.ShowDialog() == DialogResult.OK)
	                        {
	                            //创建文件，将textBox1中的内容保存到文件中
	                            //saveDlg.Fil   eName是用户指定的文件路径
                                pictureBox1.Image.Save(saveDlg.FileName,
                                    System.Drawing.Imaging.ImageFormat.Jpeg);
	                            //提示用户文件已成功保存
	                            MessageBox.Show("文件已成功保存到" + saveDlg.FileName);
	                        }
	                    }
	                    catch (System.Exception ex)
	                    {
	                        //如保存不成功，用对话框提示用户
	                        MessageBox.Show("Error!" + ex.ToString());
	                    }
        } 
        else
        {
            MessageBox.Show("图片不存在！请生成图片后重试！");    
        }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void 操作方法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("打开程序，先选择模式；生成模式可以根据字符串生成二维码，识别模式可以根据系统的二维码解码为字符串。", "操作方法", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
