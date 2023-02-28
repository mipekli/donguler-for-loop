  //Ekrandan girilen sayıya kadar olan tek sayılarını ekrana yazdır.
Console.WriteLine("Lütfen bir sayı giriniz:");
int sayac = int.Parse(Console.ReadLine());

for (int i = 0; i < sayac; i++)
{
    if (i % 2 == 1)
    { Console.WriteLine(i); }



    //Komutlar


}
    // 1 ile 1000 arasındaki tek ve Çift sayıların ken içlerinde toplamlarını ekrana yazdır.
int tektoplam = 0;
    int cifttoplam = 0;
    for (int i = 0; i < 1000; i++)
    {
        if (i % 2 == 1)
            
            tektoplam += i;
        else
            cifttoplam += i;
         
    Console.WriteLine("tektoplam:" + tektoplam);
        Console.WriteLine("çifttoplam" + cifttoplam);
    }
    // break, continue

    for (int i = 1; i < 10; i++)
{

    if (i == 4)
        break;
    Console.WriteLine(i);



}


for (int i = 1; i < 11; i++)
{

    if (i == 4)
        continue;
    Console.WriteLine(i);



}
