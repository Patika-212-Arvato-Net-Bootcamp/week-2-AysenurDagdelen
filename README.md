# week-2-AysenurDagdelen

API Katmanında aşağıdaki Controller'lar oluşturuldu.

Admin Controller içerisinde:
-Bootcamp ekleme
-Bootcamp iptal etme
-Onaylanmamış kullanıcıları listeleme
-İstenen kullanıcıyı onaylama
-Kullanıcı silme

Bootcamp Controller içerisinde:
-Tüm Bootcamp'leri listeleme
-Aktif/Pasif Bootcamp'leri listeleme
-İstenen Bootcamp'i getirme
-İstenen kullanıcıyı istenen Bootcamp'e katılımcı olarak atama

User Controller içerisinde:
-Yeni üye kaydı (Aktif etmek için Admin onayı gerekir)

Model tanımlamaları için Core Katmanı, database işlemlerinin tanımı için Repository Katmanı ve bussiness işlemlerini soyutlayarak API Katmanı ile Repository Katmanı arasında aracı olacak Service Katmanı oluşturuldu.

Herhangi bir validasyon işlemi yapılmadı. DTO kullanılmadı.
