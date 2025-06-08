# Kelime Oyunu

## Genel Bakış

Bu proje, **C# ve WinForms** kullanılarak geliştirilmiş basit bir **Kelime Oyunu**dur. Proje, **Nesne Yönelimli Programlama (OOP)** prensiplerini (kapsülleme, kalıtım, soyutlama gibi) örnekler. Oyunda, oyuncuya harfleri karıştırılmış bir kelime gösterilir ve doğru tahmini yapması beklenir.

## Özellikler

- Harici bir `.txt` dosyasından rastgele kelime yüklenmesi (1000 İngilizce kelime)
- Kelimelerin karıştırılması ve oyuncu girişinin kontrolü
- Temel puan ve tur takibi
- Nesne yönelimli mimari ile kolayca genişletilebilir yapı

## Kullanılan OOP Prensipleri

| Prensip       | Açıklama                                                                                 |
|---------------|------------------------------------------------------------------------------------------|
| **Kapsülleme** (Encapsulation) | `WordScrambleGame` oyunun iç mantığını gizler ve yalnızca gerekli metotları dışarıya sunar.        |
| **Soyutlama** (Abstraction)    | `Game` sınıfı, yüksek seviyede genel bir arayüz tanımlar.                                          |
| **Kalıtım** (Inheritance)      | `WordScrambleGame`, `Game` sınıfından türetilmiştir.                                              |
| **Çok Biçimlilik** (Polymorphism) | `Form1` içerisinde `Game` türü kullanılır (`currentGame = new WordScrambleGame()` şeklinde).        |
