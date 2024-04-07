using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Reflection.Emit;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Authentication;
using System.Security.Permissions;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab02
{
    public partial class cBai05 : Form
    {
        class cPhim
        {
            [JsonPropertyName("TenPhim")]
            public required string Ten { get; set; }
            [JsonPropertyName("GiaVeChuan")]
            public int GiaVe { get; set; }
            [JsonPropertyName("PhongChieu")]
            public int[]? PhongChieu { get; set; }
        }
        class cDanhGia
        {
            [JsonPropertyName("TenPhim")]
            public required string Ten { get; set; }
            [JsonPropertyName("SoLuongBanVe")]
            public int SoLuongBanVe { get; set; }
            [JsonPropertyName("SoLuongTonVe")]
            public int SoLuongTonVe { get; set; }
            [JsonPropertyName("TiLeBanVe")]
            public int TiLeBanRa { get; set; }
            [JsonPropertyName("DoanhThu")]
            public int DoanhThu { get; set; }
            public int XepHangDoanhThu { get; internal set; }
        }


        List<cPhim> phims = new List<cPhim>();
        List<cDanhGia> destination = new List<cDanhGia>();
        public cBai05()
        {
            InitializeComponent();

            string jsoncontent = File.ReadAllText("Input5.json");
            phims = JsonSerializer.Deserialize<List<cPhim>>(jsoncontent);

            destination = phims.Select(d => new cDanhGia
            {
                Ten = d.Ten,
                SoLuongBanVe = 0,
                SoLuongTonVe = 105,
                TiLeBanRa = 0,
                DoanhThu = 0
            }).ToList();

            ChonPhim.DataSource = phims;
            ChonPhim.DisplayMember = "Ten";
        }


        private void DatVe_Click(object sender, EventArgs e)
        {
            cPhim selectPhim = ChonPhim.SelectedItem as cPhim;
            cDanhGia selectDanhGia = destination.First(d => d.Ten == selectPhim.Ten);

            List<CheckBox> checkBoxes = Controls.OfType<CheckBox>().ToList();
            int tongTien = 0;
            int giaVe = selectPhim.GiaVe;
            int SoVeBanRa = 0;

            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    //MessageBox.Show(checkBox.Name);
                    string hangGhe = checkBox.Name.Split('_')[0];
                    int soGhe = int.Parse(checkBox.Name.Split('_')[1]);

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
                    SoVeBanRa++;
                }
            }
            selectDanhGia.SoLuongBanVe += SoVeBanRa;
            selectDanhGia.SoLuongTonVe -= SoVeBanRa;
            selectDanhGia.TiLeBanRa = (int)((double)selectDanhGia.SoLuongBanVe / 105);
            selectDanhGia.DoanhThu += tongTien;


            // Sort destination by DoanhThu in descending order and update XepHangDoanhThu
            destination = destination.OrderByDescending(d => d.DoanhThu).ToList();
            for (int i = 0; i < destination.Count; i++)
            {
                destination[i].XepHangDoanhThu = i + 1;
            }

            var options = new JsonSerializerOptions
            {
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };

            // Write destination to output5.json
            string jsonString = JsonSerializer.Serialize(destination, options);
            File.WriteAllText("Output5.json", jsonString);

            MessageBox.Show(string.Format("Tong so tien: {0}", tongTien));
        }

        private void cBai05_Load(object sender, EventArgs e)
        {
            cPhim selectedPhim = ChonPhim.SelectedItem as cPhim;
            Trong.Text = selectedPhim.Ten + " | Gia Ve: " + selectedPhim.GiaVe.ToString() + " VND";
        }

        private void ChonPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPhim selectedPhim = ChonPhim.SelectedItem as cPhim;
            ChonPhong.DataSource = selectedPhim.PhongChieu;
            Trong.Text = selectedPhim.Ten + " | Gia Ve: " + selectedPhim.GiaVe.ToString() + " VND";
        }

        private void selectDanhGia_Click(object sender, EventArgs e)
        {

        }
    }
}