## Hafta 1 — Giriş Ekranı ve Veritabanı Bağlantısı
**Tarih: 11.10.2026**

Bu hafta, şirketin stok, sipariş, üretim ve sevkiyat işlemlerini
yönetmek amacıyla geliştirilen uygulamanın giriş ekranı hazırlandı.

### Kullanılan Teknolojiler
- C# Windows Forms
- .NET Framework 4.8
- SQL Server ve SQL Server Management Studio (SSMS)
- Visual Studio

### Tamamlanan Çalışmalar
- Kullanıcı adı ve şifre alanlarını içeren giriş ekranı tasarlandı.
- Parolayı gösterme ve gizleme özelliği eklendi.
- AydenizDB veritabanı ve Kullanicilar tablosu oluşturuldu.
- Kullanıcı adı ve şifre kontrolü veritabanına bağlandı.
- Kullanıcı bulunamadığında veya şifre yanlış olduğunda kırmızı
  hata mesajı gösterilmesi sağlandı.
- Her hatalı girişte kalan giriş hakkının azalması sağlandı.
- Beş hatalı denemeden sonra giriş butonunun beş dakika
  kilitlenmesi ve kalan sürenin ekranda gösterilmesi eklendi.
- Kilit süresi dolduğunda giriş hakkının tekrar beşe
  yükseltilmesi sağlandı.
- Başarılı girişin ardından ana ekranın açılması sağlandı.

### Mevcut Sürümün Sınırları
- Hatalı giriş sayacı ve kilit süresi uygulama içinde tutulmaktadır.
  Uygulama kapatıldığında bu bilgiler sıfırlanmaktadır.
- Ana ekran oluşturulmuştur; iş modülleri henüz geliştirilmemiştir.
