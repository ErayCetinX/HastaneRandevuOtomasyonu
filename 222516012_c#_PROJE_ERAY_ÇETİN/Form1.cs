using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _222516012_c__PROJE_ERAY_ÇETİN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] hastalık = { "Kanser", "Diyabet", "Kalp hastalığı", "Alzheimer", "Astım", "Şeker hastalığı", "Parkinson hastalığı", "Hipertansiyon (yüksek tansiyon)", "Obezite", "İnme", "Kronik obstrüktif akciğer hastalığı (KOAH)", "Hepatit", "HIV/AIDS", "Multipl skleroz (MS)", "Artrit", "Osteoporoz", "Böbrek hastalığı", "Akut solunum yolu enfeksiyonu", "Grip (influenza)", "Romatizmal hastalıklar" };
            for (int i = 0; i < hastalık.Length; i++)
            {
                comboBox1.Items.Add(hastalık[i]);
            }
            string[] şehir = { "İzmir", "İstanbul", "Ankara", "Aydın", "Manisa", "Edirne", "Tekirdağ", "İzmit", "Diyarbakır", "Erzurum" };
            for (int i = 0; i < şehir.Length; i++)
            {
                citySelect.Items.Add(şehir[i]);
            }
        }


        private void btnRandevu_Click(object sender, EventArgs e)
        {
            try
            {
                // Eğer lbHastaInfoda randevu yoksa oluşturcak
                if (hospitalSelect.Text.Trim().Length > 0 && citySelect.Text.Length > 0 && lbHastaInfo.Items.Count == 0 && textBox1.Text.Trim().Length > 0 && textBox2.Text.Trim().Length > 0 && textBox3.Text.Trim().Length > 0 && comboBox1.Text.Trim().Length > 0)
                {
                    int value;
                    if (int.TryParse(textBox3.Text, out value))
                    {
                        // parsing successful 
                        // diğer eklemeleride burada yaptık
                        // eğer telefon 
                        lbHastaInfo.Text = "RANDEVU BİLGİLERİ";
                        lbHastaInfo.Items.Add($"Adınız: {textBox1.Text}");
                        lbHastaInfo.Items.Add($"Soyadınız: {textBox2.Text}");
                        lbHastaInfo.Items.Add($"Hastalığınız: {comboBox1.Text}");
                        lbHastaInfo.Items.Add($"Telefon numaranız: {value}");
                        lbHastaInfo.Items.Add($"Şehir: {citySelect.Text}");
                        lbHastaInfo.Items.Add($"Hastane: {hospitalSelect.Text}");
                    }
                    else
                    {
                        // parsing failed. 
                        MessageBox.Show("Lütfen telefon numarsını sayısal karakterlerden giriniz");
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Beklenmedik bir sorun oldu lütfen daha sonra tekrar deneyiniz");
                throw new Exception("Beklenmedik hata oldu");
            }
        }

        private void hospitalSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void citySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // her basışta 'hospitalSelect' temizlencek
            hospitalSelect.Items.Clear();
            string[] Hospitals = new string[] { "Erzurum Özel Hastanesi", " Erzurum Hastanesi", "Diyarbakır Devlet Hastanesi", "Diyarbakır Özel Hastanesi", "Manisa Şehir Hastanesi", "Manisa Hafsa Sultan Hastanesi", "İzmit Özel Hastanesi", " İzmit Devlet Hastanesi", "Tekirdağ Saray Devlet Hastanesi", "Tekirdağ Hastanesi", "Edirne Devlet Hastanesi", "Edirne Özel Hastanesi", "İzmir Medical Park", "İzmir Çiğli Devlet Hastanesi", "İstanbul Devlet Hastanesi", "İstanbul İyi Hastane", "Ankara Devlet Hastanesi", "Ankara Hacettepe Tıp Hastanesi", "Aydın Devlet Hastanesi", "Aydın Özel Hastanesi" };

            // burada user hangi şehiri seçtiyse oradaki hastaneler gelcek
            for (int j = 0; j < Hospitals.Length; j++)
            {
                string hospital = Hospitals[j];
                if (hospital.ToLower().Trim().StartsWith(citySelect.Text.ToLower()))
                {
                    hospitalSelect.Items.Add(hospital.Trim());
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lbHastaInfo.Items.Clear();
        }
    }
}
