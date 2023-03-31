using System.Drawing;
using System;

namespace Milyoner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                //# bölge  Kim Milyoner Olmak İster - V1
            Console.WriteLine(" Kim Milyoner Olmak İster \n ");
            Console.WriteLine(" İsim Giriniz: ");
            string isim = Console.ReadLine();
            Console.WriteLine(" Soyisim Girin: ");
            string soyisim = Console.ReadLine();
            Console.WriteLine("Hoş Geldin: " + isim + " " + soyisim);

                //                string isim = Konsol.Satırı Oku();
                //                konsol. (" Soyisim Giriniz: ");
                //                string soyisim = Konsol.Satırı Oku();

                //                konsol.Write(" \n 1.Telefon Jokerinizi Giriniz: ");
                //                string telefonJoker1 = Konsol.Satırı Oku();
                //                konsol.Yaz(" 2.Telefon Jokerinizi Giriniz: ");
                //                string telefonJoker2 = Konsol.Satırı Oku();
                //                konsol.Yaz(" 3.Telefon Jokerinizi Giriniz: ");
                //                string telefonJoker3 = Konsol.Satırı Oku();

                //                konsol.Temizle();
                //                konsol.WriteLine(" Hoşgeldiniz " + isim + "  " + soyisim);

                //                konsol.Yaz(" Kuralları Biliyor Musunuz? : ");
                //                char kuralCevap = char.Ayrıştır(Konsol.ReadLine().ToUpper());

                //                if (kuralCevap != 'E')
                //                {
                //                    // TODO: Kurallar eklenecek.
                //                    konsol.WriteLine(" Kurallar: asdfasdaads ");
                //                }

                //                konsol. (" Hazır Mısınız? : ");
                //                char hazirCevap = char.Ayrıştır(Konsol.ReadLine().ToUpper());

                //                if (hazirCevap != 'E')
                //                {
                //                    konsol.WriteLine(" Hazır olmanız bekleniyor. ");
                //                    konsol.WriteLine(" Hazır olduğunuzda Enter'a Basın ");
                //                    konsol.Satırı Oku();
                //                }
                //                bool seyirciHak = doğru, yuzdeHak = doğru, telefonHak = doğru;
                //                int kasa = 0;

                //                int soruNo = 1, okul, baraj;
                //                int SeyirciYuzdeA, SeyirciYuzdeB, SeyirciYuzdeC, SeyirciYuzdeD;
                //                bool gizleA, gizleB, gizleC, gizleD;
                //                dize soru, a, b, c, d;
                //                char cevap;

                //# bölge  Soru Bilgileri
                //                soruNo = 1;
                //                soru = " Türkiyenin Başkenti Neresidir? ";
                //                bir = " Ankara ";
                //                b = " Bursa ";
                //                c = " Van ";
                //                d = " Denizli ";
                //                cevap = 'A';
                //                oda = 1000;
                //                baraj = 0; // TODO: SoruNo ile baraj ilişkisi.

                //                // TODO: SoruNo ilettikleri olarak Rastgele değerlerinin olması lazım.
                //                seyirciYuzdeA = 80; seyirciYuzdeB = 10;
                //                seyirciYuzdeC = 5; seyirciYuzdeD = 5;

                //                // TODO: Daha iyi olabirlir mi? Her seferinde bunu tekrarlamaya gerek yok gibi.
                //                gizleA = false; gizleB = yanlış;
                //                gizleC = yanlış; gizleD = yanlış;
                //# son bölge
                //# bölge  Soru Kalıbı
                //            soruNoktası:
                //                konsol.Temizle();
                //                konsol.WriteLine(soruNo + " -) " + soru);
                //                konsol.WriteLine(" A) " + (!gizleA ? a : " "));
                //                konsol.WriteLine(" B) " + (!gizleB ? b : " "));
                //                konsol.WriteLine(" C) " + (!gizleC ? c : " "));
                //                konsol.WriteLine(" D) " + (!gizleD ? d : " "));

                //            yanitNoktasi:
                //                bool jokerHak = seyirciHak || yüzdeHak || telefonHak;

                //                konsol.Write(" Cevabınızı Giriniz veya ");
                //                if (jokerHak) Konsolu.Yaz(" Joker için J'ye, ");
                //                konsol.Write(" Çekilmek için R'ye Basınız: ");
                //                char secim = char.Ayrıştır(Konsol.ReadLine().ToUpper());

                //                if (secim == 'J')
                //                {
                //                    eğer(!jokerHak)
                //                    {
                //                        konsol.WriteLine(" Joker Hakkınız Bitmiştir.. ");
                //                        yanitNoktasi'na git ;
                //                }

                //                    konsol.WriteLine(" 1-) " + (seyirciHak ? " Seyirci " : " "));
                //                    konsol.WriteLine(" 2-) " + (yuzdeHak ? " %50 " : " "));
                //                    konsol.WriteLine(" 3-) " + (telefonHak ? " Telefon " : " "));
                //                    konsol. (" Seçiminizi Yapınız : ");
                //                    int jokerCevap = int.Ayrıştır(Konsol.ReadLine());

                //                    if (jokerCevap == 1 && SeyirciHak)
                //                    {
                //                        konsol.WriteLine(" A) % " + seyirciYuzdeA);
                //                        konsol.WriteLine(" B) % " + seyirciYuzdeB);
                //                        konsol.WriteLine(" C) % " + seyirciYuzdeC);
                //                        konsol.WriteLine(" D) % " + seyirciYuzdeD);
                //                        seyirciHak = false;
                //                    }
                //                    else if (jokerCevap == 2 && yuzdeHak)
                //                    {
                //                        // TODO: Bu kısım sorudan bağımsız olarak kullanılabilmeli.
                //                        gizleB = true;
                //                        gizleC = true;

                //                        yüzdeHak = yanlış;
                //                        soruNoktası'na git ;
                //                    }
                //                    else if (jokerCevap == 3 && telefonHak)
                //                    {
                //                        konsol.WriteLine(" 1-) " + telefonJoker1);
                //                        konsol.WriteLine(" 2-) " + telefonJoker2);
                //                        konsol.WriteLine(" 3-) " + telefonJoker3);
                //                        konsol.Yaz(" Kimi Aramak İstersiniz? : ");
                //                        int telefonCevap = int.Ayrıştır(Konsol.ReadLine());

                //                        if (soruNo <= 7 || telefonCevap == 3) Konsol.WriteLine(" Kesinlikle Cevap " + cevap);
                //                        else if (telefonCevap == 1) // TODO: Şıklar rastgele olacak. 1Doğru 1Yanlış cevap şeklinde
                //                            konsol.WriteLine(" Emin Değilim. Ancak A veya B olduğunu düşünüyorum ");
                //                        else if (telefonCevap == 2)
                //                            konsol.WriteLine(" Bilemedim. Kusura bakma ");
                //                        telefonHak = yanlış;
                //                    }
                //                    başka
                //                        konsol.WriteLine(" Bu Joker Daha Önce Kullanıldı.. ");

                //                    yanitNoktasi'na git ;
                //                }
                //                else if (secim == 'R')
                //                {
                //                    konsol.WriteLine(kasa + " TL Kazanacaksınız. ");
                //                    konsol.Write(" Çekilmeye Emin Misiniz? : ");
                //                    char çekilCevap = char.Ayrıştır(Konsol.ReadLine());

                //                    if (çekilCevap == 'E')
                //                    {
                //                        konsol.WriteLine(" Tebrikler, " + kasa + " TL Kazandınız. ");
                //                        konsol.WriteLine(" Oyun Bitti ");
                //                        // dönüş;
                //                        çevre.Çıkış(0);
                //                    }
                //                    soruNoktası'na git ;
                //                }
                //                else if (secim != cevap)
                //                {
                //                    konsol.WriteLine(" Elendiniz, Kazandığınız Tutar: " + baraj + " TL ");
                //                    konsol.WriteLine(" Oyun Bitti ");
                //                    // dönüş;
                //                    çevre.Çıkış(0);
                //                }

                //                kasa = ödul;
                //                konsol.WriteLine(" Tebrikler, Kazandığınız Tutar: " + kasa + " TL ");
                //                konsol.WriteLine(" \n Sonraki Soruya Geçmek İçin Enter'a Basın.. ");
                //                konsol.Satırı Oku();
                //# son bölge


                //# son bölge
            
        }
    }
}