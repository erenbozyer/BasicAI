## 🚀 Kurulum ve API Anahtarı Yapılandırması

Uygulamanın çalışabilmesi için bir Google Gemini API anahtarına ihtiyacınız vardır. Aşağıdaki adımları takip ederek kurulumu tamamlayabilirsiniz:

### 1. API Anahtarı Alma

1. **Google AI Studio** adresine gidin: [aistudio.google.com](https://aistudio.google.com/)
2. Google hesabınızla giriş yapın.
3. Sol paneldeki **"Get API key"** butonuna tıklayın.
4. **"Create API key in new project"** seçeneği ile anahtarınızı oluşturun.
5. Oluşturulan karmaşık kodu kopyalayın.

### 2. API Anahtarını Koda Ekleme

Projeyi Visual Studio ile açtıktan sonra `MainForm.cs` dosyasına gidin. Aşağıdaki satırı bulun ve kopyaladığınız anahtarı tırnak içine yapıştırın:

```csharp
[cite_start]// Standart: Private değişkenler '_' ile başlar [cite: 251, 413]
private readonly string _geminiApiKey = "BURAYA_KOPYALADIGINIZ_KEYI_YAZIN";

```

### 3. Bağımlılıkların Yüklenmesi

Uygulama JSON işlemleri için **Newtonsoft.Json** kütüphanesini kullanır. Visual Studio'da:

1. **Tools > NuGet Package Manager > Manage NuGet Packages for Solution** yolunu izleyin.
2. `Newtonsoft.Json` araması yapın ve projenize yükleyin.

---

## 🛠 Teknik Detaylar

### Kullanılan Teknolojiler
* Dil: C# (.NET Framework 4.8 / .NET 6+)
* Mimari: Nesne Tabanlı Programlama (OOP) ve Katmanlı Mimari Yaklaşımı 
* Veri Formatı: JSON (API iletişimi için)
