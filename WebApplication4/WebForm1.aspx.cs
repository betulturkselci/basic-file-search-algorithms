using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;
using System.Data;
using System.Drawing;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebApplication4
{

    public partial class WebForm1 : System.Web.UI.Page
    {
        //Kaynak: https://www.youtube.com/watch?v=K2U40hD42BQ&list=LL&index=9
        private void GetAllFiles(string sDir, string uzanti)
        {
            foreach (string dir in Directory.GetDirectories(sDir))
            {
                try
                {
                    foreach (string file in Directory.GetFiles(dir, "*" + uzanti))
                    {
                        string txtFile = Path.GetFileName(file);
                        ListBox1.Items.Add(txtFile);
                    }
                    
                }
                catch (Exception Error)
                {
                    ListBox1.Items.Add("Error");
                }
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string path = "E:\\" + TextBox1.Text;
            string[] ffile = Directory.GetFiles(path);
            for (int i = 0; i < ffile.Length; i++)
            {
                ListBox1.Items.Add(ffile[i].ToString());
            }
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
        }


        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }

       

        protected void Button4_Click(object sender, EventArgs e)
        {
            string path = "E:\\doodle\\" + TextBox1.Text;

            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string path = "E:\\doodle\\" + TextBox1.Text;

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

              

        protected void Button9_Click(object sender, EventArgs e)
        {            
            string[] kelimeler = TextBox1.Text.Split(' ');
            string title = kelimeler[0];
            if (title == "select")
            {
                if (kelimeler[2] == "from")
                {
                    if (kelimeler[4] == "where")
                    {
                        if (kelimeler[1] == "fileType" )
                        {
                            if (kelimeler[5] == "fileType=")
                            {
                                string harf = kelimeler[3].ToCharArray()[0].ToString();
                                if (harf == "E" || harf == "C" || harf == "D")
                                {
                                    GetAllFiles(kelimeler[3], kelimeler[6]);
                                }
                                else
                                {
                                    ListBox1.Items.Add("HATA!! Directory yazımı hatalı!!");
                                }

                            }
                            else
                            {
                                ListBox1.Items.Add("HATA!!(girilen kosul yazımı hatalı)");
                            }
                           
                        }
                        else if(kelimeler[1] == "name" )
                        {
                            if(kelimeler[5] == "name=")
                            {
                                string path = kelimeler[3] + kelimeler[6];
                                string[] ffile = Directory.GetFiles(path);
                                for (int i = 0; i < ffile.Length; i++)
                                {
                                    ListBox1.Items.Add(ffile[i].ToString());
                                }
                            }
                            else
                            {
                                ListBox1.Items.Add("HATA!!(girilen kosul yazımı hatalı)");
                            }

                        }
                        else
                        {
                            ListBox1.Items.Add("HATA!!(İstenilen tür girisi hatalı.)");
                        }
                    }
                    else
                    {
                        ListBox1.Items.Add("HATA!!(where eksik)");
                    }
                }
                else
                {
                    ListBox1.Items.Add("HATA!!(from eksik veya isim eksik)");
                }
            }
            else if (title == "insert")
            {               
                string harf = kelimeler[3].ToCharArray()[0].ToString();
                if (harf == "E" || harf == "C" || harf == "D")
                {
                    if (kelimeler[2] == "to")
                    {
                        //Kaynak: https://www.youtube.com/watch?v=9zQzRAx66aM&list=LL&index=14
                        string path2 = kelimeler[3] + kelimeler[1];
                        if (!File.Exists(path2))
                        {                            
                            File.Create(path2);
                            ListBox1.Items.Add("Dosya olusturuldu.");
                        }                         
                        else
                        {
                            ListBox1.Items.Add("HATA!! Bu isimde bir dosya bulunuyor farklı isim verin.");
                        }
                    }
                    else
                    {
                        ListBox1.Items.Add("HATA!! Eksik yazım!!");
                    }
                }
                else
                {
                    ListBox1.Items.Add("HATA!! Directory yazımı hatalı!!");
                }
            }
            else if(title == "delete")
            {
                string harf = kelimeler[3].ToCharArray()[0].ToString();
                if (harf == "E" || harf =="C" || harf == "D")
                {
                    if (kelimeler[2] == "from")
                    {
                        string path2 = kelimeler[3] + kelimeler[1];
                        if (File.Exists(path2))
                        {
                            File.Delete(path2);
                            ListBox1.Items.Add("Dosya silindi.");
                        }
                        else if (Directory.Exists(path2))
                        {
                            Directory.Delete(path2,true);
                            ListBox1.Items.Add("Dosya silindi.");
                        }
                        else
                        {
                            ListBox1.Items.Add("HATA!! Bu isimde bir dosya bulunmuyor.");
                        }
                    }
                    else
                    {
                        ListBox1.Items.Add("HATA!! Eksik yazım!!");
                    }
                }
                else
                {
                    ListBox1.Items.Add("HATA!! Directory yazımı hatalı!!");
                }
            }
            else
            {
                ListBox1.Items.Add("HATA!! Lutfen insert,delete ya da select kelimelerini kullanın.");
            }
        }
    }
}