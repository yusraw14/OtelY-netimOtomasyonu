using denemeotel.BL;
using denemeotel.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeotel
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
            TxtOdaNumarasi.ReadOnly = true; 

            foreach (Control item in groupBox2.Controls)
            {
                if (item is Button btn && btn.Name.StartsWith("btnOda"))
                {
                    btn.Click += new EventHandler(OdaButonu_Click);
                    btn.BackColor = Color.LightGreen;
                }
            }

            dtpGiris.ValueChanged += new EventHandler(Tarih_ValueChanged);
            dtpCikis.ValueChanged += new EventHandler(Tarih_ValueChanged);

            OdaDurumlariniGuncelle();
        }

        private void Tarih_ValueChanged(object sender, EventArgs e)
        {
            if (dtpGiris.Value > dtpCikis.Value)
            {
                MessageBox.Show("Giriş tarihi çıkış tarihinden sonra olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpCikis.Value = dtpGiris.Value.AddDays(1);
                return;
            }
            OdaDurumlariniGuncelle();
        }

        private void OdaDurumlariniGuncelle()
        {
            try
            {
                using (var conn = new baglantı().getir())
                {
                    MySqlCommand cmd = new MySqlCommand(@"
                        SELECT DISTINCT r.RoomNumber 
                        FROM Rooms r
                        INNER JOIN Reservations res ON r.RoomNumber = res.RoomNumber
                        WHERE NOT (res.CheckOutDate < @checkIn OR res.CheckInDate > @checkOut)", conn);

                    cmd.Parameters.AddWithValue("@checkIn", dtpGiris.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@checkOut", dtpCikis.Value.ToString("yyyy-MM-dd"));

                    foreach (Control item in groupBox2.Controls)
                    {
                        if (item is Button btn && btn.Name.StartsWith("btnOda"))
                        {
                            btn.BackColor = Color.LightGreen;
                        }
                    }

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string odaNo = reader["RoomNumber"].ToString();
                            foreach (Control item in groupBox2.Controls)
                            {
                                if (item is Button btn && btn.Name.StartsWith("btnOda") && btn.Text == odaNo)
                                {
                                    btn.BackColor = Color.Red;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda durumları güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool OdaMusaitMi(string odaNo, DateTime girisTarihi, DateTime cikisTarihi)
        {
            try
            {
                using (var conn = new baglantı().getir())
                {
                    MySqlCommand cmd = new MySqlCommand(@"
                        SELECT COUNT(*) 
                        FROM Reservations 
                        WHERE RoomNumber = @roomNumber 
                        AND NOT (CheckOutDate < @checkIn OR CheckInDate > @checkOut)", conn);

                    cmd.Parameters.AddWithValue("@roomNumber", odaNo);
                    cmd.Parameters.AddWithValue("@checkIn", girisTarihi.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@checkOut", cikisTarihi.ToString("yyyy-MM-dd"));

                    int cakismaVarMi = Convert.ToInt32(cmd.ExecuteScalar());
                    return cakismaVarMi == 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void OdaButonu_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            if (!OdaMusaitMi(btn.Text, dtpGiris.Value, dtpCikis.Value))
            {
                MessageBox.Show("Seçtiğiniz tarih aralığında bu oda dolu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TxtOdaNumarasi.Text = btn.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void txtAdi_Click(object sender, EventArgs e)
        {

        }

        private void txtOdaNumarasi_Click(object sender, EventArgs e)
        {

        }

        private void TxtAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try 
            {
                if (string.IsNullOrWhiteSpace(TxtAdi.Text) || 
                    string.IsNullOrWhiteSpace(TxtSoyadi.Text) || 
                    string.IsNullOrWhiteSpace(maskedTextBox1.Text) ||
                    string.IsNullOrWhiteSpace(TxtOdaNumarasi.Text) ||
                    string.IsNullOrWhiteSpace(TxtUcret.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (TxtTCkimlik.Text.Length != 11 || !long.TryParse(TxtTCkimlik.Text, out _))
                {
                    MessageBox.Show("Lütfen geçerli bir TC Kimlik numarası giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtpGiris.Value > dtpCikis.Value)
                {
                    MessageBox.Show("Giriş tarihi çıkış tarihinden sonra olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!OdaMusaitMi(TxtOdaNumarasi.Text, dtpGiris.Value, dtpCikis.Value))
                {
                    MessageBox.Show("Seçtiğiniz tarih aralığında bu oda başkası tarafından rezerve edilmiş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var müşteriKayıt = new blmüşterikayıt();
                bool sonuç = müşteriKayıt.MüşteriKaydet(
                    TxtAdi.Text.Trim(), 
                    TxtSoyadi.Text.Trim(), 
                    maskedTextBox1.Text.Trim(), 
                    TxtTCkimlik.Text.Trim(),
                    TxtOdaNumarasi.Text.Trim(), 
                    TxtUcret.Text.Trim(),
                    dtpGiris.Value.ToString("yyyy-MM-dd"), 
                    dtpCikis.Value.ToString("yyyy-MM-dd")
                );

                if (sonuç)
                {
                    OdaDurumlariniGuncelle();

                    TxtAdi.Text = "";
                    TxtSoyadi.Text = "";
                    maskedTextBox1.Text = "";
                    TxtTCkimlik.Text = "";
                    TxtOdaNumarasi.Text = "";
                    TxtUcret.Text = "";
                    dtpGiris.Value = DateTime.Now;
                    dtpCikis.Value = DateTime.Now;
                    
                    MessageBox.Show("Müşteri ve rezervasyon başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOda101_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
