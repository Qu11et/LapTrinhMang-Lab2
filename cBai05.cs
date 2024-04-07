using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab02
{
    public partial class cBai05 : Form
    {
        class Phim
        {
            [JsonPropertyName("TenPhim")]
            public required string Ten { get; set; }
            [JsonPropertyName("GiaVeChuan")]
            public int GiaVe { get; set; }
            [JsonPropertyName("PhongChieu")]
            public int[]? PhongChieu { get; set; }
        }
        public cBai05()
        {
            InitializeComponent();
            List<Phim> phims = new List<Phim>();
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Json|*.json";
            open.ShowDialog();
            FileStream fileStream = new FileStream(open.FileName, FileMode.Open);
            phims = JsonSerializer.Deserialize<List<Phim>>(fileStream);


            ChonPhim.DataSource = phims;
            ChonPhim.DisplayMember = "Ten";
        }

        private void DatVe_Click(object sender, EventArgs e)
        {
            Phim selectPhim = ChonPhim.SelectedItem as Phim;
            List<CheckBox> checkBoxes = Controls.OfType<CheckBox>().ToList();
            int tongTien = 0;
            int giaVe = selectPhim.GiaVe;

            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    //MessageBox.Show(checkBox.Name);
                    string hangGhe = checkBox.Name.Split('_')[0];
                    int soGhe = int.Parse(checkBox.Name.Split("_")[1]);

                    if (soGhe == 1 || soGhe == 5)
                    {
                        tongTien += giaVe / 2;
                    }
                    else
                    {
                        if (hangGhe.Equals("B"))
                        {
                            tongTien += giaVe * 2;
                        }
                        else
                        {
                            tongTien += giaVe;
                        }
                    }
                }
            }

            MessageBox.Show(string.Format("Tong so tien: {0}", tongTien));
        }

        private void cBai05_Load(object sender, EventArgs e)
        {
            Phim selectedPhim = ChonPhim.SelectedItem as Phim;
            Trong.Text = selectedPhim.Ten + " | Gia Ve: " + selectedPhim.GiaVe.ToString()+" VND";
        }

        private void ChonPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            Phim selectedPhim = ChonPhim.SelectedItem as Phim;
            ChonPhong.DataSource = selectedPhim.PhongChieu;
            Trong.Text = selectedPhim.Ten + " | Gia Ve: " + selectedPhim.GiaVe.ToString() + " VND";
        }

    }
}