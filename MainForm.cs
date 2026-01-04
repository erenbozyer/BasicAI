using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Linq;

namespace Firat.Asistan.Forms
{
    public partial class MainForm : Form
    {
       
        private readonly string _geminiApiKey = "API_KEY";
        private readonly string _apiUrl = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-flash:generateContent?key=";

        public MainForm()
        {
            InitializeComponent();
           
            rtxtSohbet.BackColor = System.Drawing.Color.LightYellow;
        }

        private async void btnGonder_Click(object sender, EventArgs e)
        {
            
            string mesajMetni = txtMesaj.Text.Trim();

           
            if (string.IsNullOrWhiteSpace(mesajMetni))
            {
                MessageBox.Show("Boş mesaj gönderilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            rtxtSohbet.AppendText($"Siz: {mesajMetni}\n");
            txtMesaj.Clear();
            btnGonder.Enabled = false; // Çift tıklamayı engelle

            try
            {
                string cevap = await GeminiCevapAl(mesajMetni);
                rtxtSohbet.AppendText($"AI: {cevap}\n\n");

              
                lstGecmis.Items.Add($"{DateTime.Now:HH:mm} - {mesajMetni.Substring(0, Math.Min(10, mesajMetni.Length))}...");
            }
            catch (Exception ex)
            {
     
                MessageBox.Show("API Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGonder.Enabled = true;
                rtxtSohbet.ScrollToCaret();
            }
        }

        private async Task<string> GeminiCevapAl(string mesaj)
        {
            using (var client = new HttpClient())
            {
                var requestBody = new
                {
                    contents = new[] { new { parts = new[] { new { text = mesaj } } } }
                };

                string json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(_apiUrl + _geminiApiKey, content);
                string responseJson = await response.Content.ReadAsStringAsync();

                // HATA BURADAYDI: Gelen JSON'u önce kontrol etmeliyiz
                if (!response.IsSuccessStatusCode)
                {
                    return "Hata: " + response.StatusCode + " - " + responseJson;
                }

                dynamic result = JsonConvert.DeserializeObject(responseJson);

                // Null Kontrolü (O siktiriboktan hatayı engelleyen kısım)
                if (result?.candidates != null && result.candidates.Count > 0)
                {
                    return result.candidates[0].content.parts[0].text;
                }

                return "AI cevap veremedi (Boş içerik).";
            }
        }
    }
}