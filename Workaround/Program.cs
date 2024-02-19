// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;
using System;

class Program
{
	static void Main(string[] args)
	{

		SelamVer("isim");
		SelamVer("Ahmet");
		SelamVer("Alper");
		SelamVer();

		int sonuc = topla(6, 58);
		//Diziler-Arrays
		//string ogrenci1 = "Engin";
		//string ogrenci2 = "Kerem";
		//string ogrenci3 = "Berat";

		string[] ogrenciler = new string[3];
		ogrenciler[0] = "Engin";
		ogrenciler[1] = "Kerem";
		ogrenciler[2] = "Berat";

		ogrenciler = new string[4];
		ogrenciler[3] = "İlker";
		for (int i=0; i<ogrenciler.Length; i++)
		{
			Console.WriteLine(ogrenciler[i]);
		}

		string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
		string[] sehirler2 = new[] { "Bursa", "Antalya", "Giresun" };

		sehirler2 = sehirler1;
		sehirler1[0] = "Adana";
		Console.WriteLine(sehirler2[0]);

		Person person1 = new Person();
		person1.FirstName = "Engin";
		person1.LastName = "Demiroğ";
		person1.DateOfBirthYear = 1985;
		person1.NationalIdentity = 123;

		Person person2 = new Person();
		person2.FirstName = "Berat";
		person2.LastName = "Aktaş";
		person2.DateOfBirthYear = 1999;
		person2.NationalIdentity = 456;

        foreach (string sehir in sehirler1)
        {
			Console.WriteLine(sehir);

        }
		List<string> yenisehirler1 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };
		yenisehirler1.Add("Adana1");
        foreach (var sehir in yenisehirler1)
        {
			Console.WriteLine(sehir);
        }

		PttManager pttManager = new PttManager(new PersonManager());
		pttManager.GiveMask(person1);
		pttManager.GiveMask(person2);
		

        Console.ReadLine();
	}


	//default parametre 
	//resharper
	static void SelamVer(string isim="isimsiz")
	{
		Console.WriteLine("Merhaba" + isim);
	}
	static int topla(int sayi1=5, int sayi2=10)
	{
		
		int sonuc = sayi1 + sayi2;
		Console.WriteLine("Toplam" + sonuc.ToString());
		return sonuc;
	}
	private static void degiskenler()
	{
		string mesaj = "Selam";
		double tutar = 10000;
		int sayi = 100;
		bool girisYapmismi = false;

		string ad = "Berat";
		string soyad = "Aktaş";
		int dogumyili = 1985;
		long tcno = 12345678910;

		Console.WriteLine(mesaj);
		Console.WriteLine(mesaj);
		Console.WriteLine(tutar * 1.18);
	}
}
//pascal casing
public class Vatandas 
{

   public string Ad { get; set; }
   public string Soyad { get; set; }
   public int DogumYili { get; set; }
   public long TcNo { get; set; }
 
}
