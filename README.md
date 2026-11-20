# BursaRunner — Koş Bursalı, Timsah Olma!

Bursa'nın simgelerinin arasında geçen, 2D pixel art sonsuz koşu oyunu. Uludağ'ın eteğinden başlayıp Yeşil Türbe, Irgandı Köprüsü, Heykel ve Suuçtu Şelalesi'ne uzanan yolda engellerden kaç, kestaneleri topla, rekoru kır. Bir an durursan... **TİMSAH OLDUN!**

## Nasıl Oynanır?

| Tuş | Hareket |
|---|---|
| **D** (basılı tut) | Koş |
| **Space** | Zıpla |

- Kestaneleri topla, skorunu artır
- Tramvayın **üstüne** çıkabilirsin ama **yanına** çarparsan oyun biter
- Engele takılırsan "TİMSAH OLDUN!" ekranı gelir

## Özellikler

- Bursa temalı sahneler: Ulucami silueti, nostaljik tramvay, Uludağ, Yeşil Türbe, Irgandı Köprüsü, Suuçtu Şelalesi
- Koşulan mesafe arttıkça değişen arka planlar
- Kestane toplama ve mesafe skoru
- Rastgele engel dalgaları (tramvay, kestane arabası)
- Unity Animator ile durma, koşma ve zıplama animasyonları
- Ana menü ve "TİMSAH OLDUN!" oyun sonu ekranı

## Teknik Detaylar

- **Motor:** Unity 6 (6000.3), Universal Render Pipeline 2D
- **Dil:** C#
- **Başlıca betikler** (`Assets/` ve `Assets/Scripts/`):
  - `PlayerController.cs` — koşma, zıplama, tramvayın üstüne çıkma / yandan çarpma kontrolü
  - `ObstacleSpawner.cs` — rastgele engel ve kestane dalgaları
  - `ScoreManager.cs` — mesafe ve kestane sayacı
  - `BackgroundChanger.cs` — her 150 metrede arka planı değiştirme
  - `GroundLoop.cs`, `MoveLeft.cs` — sonsuz zemin ve kayan nesneler
  - `GameManager.cs`, `MenuManager.cs` — oyun sonu, yeniden başlatma ve menü

## Çalıştırma

1. Projeyi Unity Hub ile **Unity 6000.3.10f1** (veya uyumlu bir Unity 6 sürümü) kullanarak açın.
2. `Assets/Scenes/Menu.unity` sahnesini açıp **Play**'e basın.

## Görseller ve Telif Hakkı

Oyundaki karakter tasarımı ve animasyon kareleri, arka planlar, engeller ve simgeler dahil **tüm görseller İbrahim Efe Yokuş'a aittir**. Projede hazır asset kullanılmamıştır.

© 2026 İbrahim Efe Yokuş. Tüm hakları saklıdır. Bu depodaki görseller ve kod, sahibinin yazılı izni olmadan kopyalanamaz, değiştirilemez, dağıtılamaz veya başka projelerde kullanılamaz.

`Assets/TextMesh Pro` klasörü Unity'nin TextMesh Pro paketine aittir ve kendi lisans koşullarına tabidir.
