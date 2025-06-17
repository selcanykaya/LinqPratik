Random random = new Random(); // Rastgele sayı üretmek için Random sınıfı

List<int> sayilar = new List<int>(); // Sayıları tutacak liste

// Rastgele 10 adet sayı ekleme
for (int i = 0; i < 10; i++)
{
    sayilar.Add(random.Next(-20,20)); // -50 ile 50 arasında rastgele sayılar
}

Console.WriteLine("Sayılar:"); // Tüm sayıları yazdırma

foreach (var sayi in sayilar)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("-------------------------------------------");

// Çift olan sayılar

Console.WriteLine("Çift Sayılar:");

var ciftSayilar = sayilar.Where(x => x % 2 == 0);

foreach (var sayi in ciftSayilar)
{
    Console.WriteLine(sayi);
}
Console.WriteLine("---------------------------------------------");

// Tek olan sayılar

Console.WriteLine("Tek Sayılar:");

var tekSayilar = sayilar.Where(x => x % 2 == 1 || x % 2 == -1);

foreach (var sayi in tekSayilar)
{
    Console.WriteLine(sayi);
}

// Negatif sayılar

Console.WriteLine("Negatif Sayılar:");

var negatifSayilar = sayilar.Where(x => x < 0);

foreach (var sayi in negatifSayilar)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("-----------------------------------------------");

// Pozitif sayılar

Console.WriteLine("Pozitif Sayılar:");

var pozitifSayilar = sayilar.Where(x => x > 0);

foreach (var sayi in pozitifSayilar)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("------------------------------------------------");

// 15'ten büyük ve 22'den küçük sayılar

Console.WriteLine("15'ten Büyük ve 22'den Küçük Sayılar:");

var yeniSayilar = sayilar.Where(x => x > 15 && x < 22);

foreach (var sayi in yeniSayilar)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("-------------------------------------------------");

// Listedeki her bir sayının karesi

Console.WriteLine("Sayıların Kareleri:");

var karesi = sayilar.Select(x => x * x); // Her sayının karesini hesaplayıp yeni bir liste oluşturma

foreach (var sayi in karesi)
{
    Console.WriteLine(sayi);
}