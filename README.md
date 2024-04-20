Sinema Seans Takip Uygulaması
Bu uygulama, sinema salonlarında gösterilen filmlerin ve bu filmlere ait seansların takibini sağlayan bir Windows Forms uygulamasıdır. Kullanıcılar, filmleri, salonları ve seansları ekleyebilir, düzenleyebilir ve silebilirler.
Proje Tasarımı
Proje, Windows Forms uygulaması olarak tasarlanmıştır. Tek bir form üzerinde tab component kullanılacak.

Film Tabı
Film tabı, filmin adı, yönetmeni, yayınlanma tarihi, süresi ve açıklamasının tanımlanıp kaydedileceği bir alan içerecek.

Ana tab sayfamızın görünümü bu şekildedir herhangi bir seçenek seçilir ve devam edilir, seç butonuna bastıktan sonra karşımıza bir sonraki tab formu gelir.
![anagiris](https://github.com/korayeris/SinemaTakip/assets/131859594/e1cee09f-021e-4134-a1b9-2de0e6dfe7ea)

Gerekli veriler doldurulur ve onayla butonuna basılır.
![filmverigirisi](https://github.com/korayeris/SinemaTakip/assets/131859594/e93f0266-e456-4b30-b143-17fcb0477170)
Ardından DBeaver uygulamasına kurduğumuz database kontrol edilir, veriler başarıyla tablomuza eklenmiştir.
![filmdb](https://github.com/korayeris/SinemaTakip/assets/131859594/0ec6182f-637c-498e-848a-11e02ae05150)


Salon Tabı
Salon tabı, salonun adı ve koltuk kapasitesinin tanımlanacağı bir alan içerir.

Gerekli veriler girilir ve onaylanır.
![salontabı](https://github.com/korayeris/SinemaTakip/assets/131859594/dd0fb698-ebc4-45dc-91bd-62d1990cdc8e)

Database kontol edilir.
![salondb](https://github.com/korayeris/SinemaTakip/assets/131859594/84967278-e127-4569-80e8-1591013c43b4)


Seans Tabı
Seans tabı, Filmid, Salonid, Başlangıç Saati, Süre ve Ücret kısımlarının doldurulucağı alanları içerir.

Gerekli veriler girilir ve onaylanır.
![seanstab](https://github.com/korayeris/SinemaTakip/assets/131859594/0a95293f-e9de-418e-8625-b46a2d4a5591)

Database kontol edilir.
![seansdb](https://github.com/korayeris/SinemaTakip/assets/131859594/fca3eb6a-d0c9-4e79-8d32-e793cccf4d9a)

Seans Diagramı:
![seansdiagram](https://github.com/korayeris/SinemaTakip/assets/131859594/da7dd91a-e2fc-42ff-8200-20c914119059)


Databasein genel görünüşü:
![db](https://github.com/korayeris/SinemaTakip/assets/131859594/a8c1eb57-cb9a-4ed3-947e-13edd887c3d8)


-C# programlama dili kullanılmıştır
Windows Forms (WinForms) teknolojisi

