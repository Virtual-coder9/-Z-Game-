using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K4R98_Q_ant_m
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, l, m, n, o, p;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorVisible = false;
            Console.SetCursorPosition(1, 1);
            for (k = 0; k <= 99; k++)
            {
                Console.Write("\n");
                for (l = 0; l < k; l++)
                {
                    Console.Write("█");
                }
                Console.Write("%" + k);
                Console.SetCursorPosition(1, 1);
                System.Threading.Thread.Sleep(1);
                if (k != 100)
                {
                    Console.WriteLine("\n");
                    Console.Write("Yükleniyor");
                    for (m = 1; m <= 4; m++)
                    {
                        System.Threading.Thread.Sleep(1);
                        Console.Write(".");
                    }
                    Console.Clear();
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            for (m = 1; m <= 1; m++)
            {
                for (n = 1; n <= m; n++)
                {
                    Console.Write("\tB<3\t\t\t\t\tY");
                }
                Console.Write("\n");
                for (m = 1; m <= 1; m++)
                {
                    for (n = 1; n <= m; n++)
                    {
                        Console.Write("\t\tBa<3\t\t\t\t\tY4");
                    }
                    Console.Write("\n");
                    for (m = 1; m <= 1; m++)
                    {
                        for (n = 1; n <= m; n++)
                        {
                            Console.Write("\t\t\tBar<3\t\t\t\t\tY4`Mo");
                        }
                        Console.Write("\n");
                        for (m = 1; m <= 1; m++)
                        {
                            for (n = 1; n <= m; n++)
                            {
                                Console.Write("\t\t\t\tBarı<3\t\t\t\t\t\tY4`Mon1");
                            }
                            Console.Write("\n");
                            for (m = 1; m <= 1; m++)
                            {
                                for (n = 1; n <= m; n++)
                                {
                                    Console.Write("\t\t\t\t\tBarış<3\t\t\t\t\t\t\tY4`Mon1ca!");
                                }
                                Console.Write("\n");
                            }
                            for (o = 5; o >= 1; o--)
                            {
                                for (p = 4; p <= o - 1; p++)
                                {
                                    Console.WriteLine("\t\t\t\tAkın<3");
                                }
                            }
                            for (o = 5; o >= 1; o--)
                            {
                                for (p = 4; p <= o - 1; p++)
                                {
                                    Console.WriteLine("\t\t\tAkı<3");
                                }
                            }
                            for (o = 5; o >= 1; o--)
                            {
                                for (p = 4; p <= o - 1; p++)
                                {
                                    Console.WriteLine("\t\tAk<3");
                                }
                            }
                            for (o = 5; o >= 1; o--)
                            {
                                for (p = 4; p <= o - 1; p++)
                                {
                                    Console.WriteLine("\tA<3");
                                }
                            }
                        }
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            string a, d;
        b:
            Console.Clear();
            Console.WriteLine("\n");
            Console.Write("\tHangi ZSL takımı ve kadrosuna bakıcaksın?(Takımlar:1907 Fenerbahçe,Beşiktaş,Bursa E-spor,Çamlıca E-spor,Gamers\n\n\t\t of Future,Galatasatay,Fastpay Wildcats,Dark Passage,İstanbul E-spor,M0D-Z)-_->>>");
            a = Console.ReadLine();
            if (a == "1907 Fenerbahçe")
            {
                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine("\t1907 FENERBAHÇE");
                Console.WriteLine("\n");
                Console.WriteLine("\tFB`OXMANN\t\t\tFB`ALAF4N");
                Console.WriteLine("\n\tAytekin ÇAKIR\t[20]\t\tOrhan Özgür ÇETİN   [20]");
                Console.WriteLine("\n\tKDA-_->>>NaN\t\t\tKDA-_->>>1,04");
                Console.WriteLine("\n");
                Console.WriteLine("\tFB`BiXiBeeZy\t\t\tFB`Arroow");
                Console.WriteLine("\n\tMert BAŞÇOBAN\t[23]\t\tBerkay ÖZDEMİR   [20]");
                Console.WriteLine("\n\tKDA-_->>>1,23\t\t\tKDA-_->>>1,27");
                Console.WriteLine("\n");
                Console.WriteLine("\tFB`witdood\t\t\tFB`Rebel");
                Console.WriteLine("\n\tOğuzhan ÜNLÜ\t[22]\t\tEmir Karaduman   [20]");
                Console.WriteLine("\n\tKDA-_->>>1,22\t\t\tKDA-_->>>Nan");
                Console.WriteLine("\n");
                Console.WriteLine("\tFB`Masic");
                Console.WriteLine("\n\tSermet DEMİRER\t[20]");
                Console.WriteLine("\n\tKDA-_->>>1,14");
                System.Threading.Thread.Sleep(5000);
                goto c;
            }
            if (a == "Beşiktaş")
            {
                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine("\tBeşiktaş");
                Console.WriteLine("\n");
                Console.WriteLine("\tBJK`swooN\t\t\tBJK`W4siLi");
                Console.WriteLine("\n\tHakan DEMİREL\t[28]\t\tErtuğrul PALA   [26]");
                Console.WriteLine("\n\tKDA-_->>>1,45\t\t\tKDA-_->>>1,33");
                Console.WriteLine("\n");
                Console.WriteLine("\tBJK`Dr.Goupo\t\t\tBJK`KeeVz");
                Console.WriteLine("\n\tBurak KUNOVAC\t[21]\t\tErdem ŞENTÜRK   [21]");
                Console.WriteLine("\n\tKDA-_->>>1,27\t\t\tKDA-_->>>1,49");
                Console.WriteLine("\n");
                Console.WriteLine("\tBJK`Unity\t\t\tBJK`Megasound");
                Console.WriteLine("\n\tCihan SEFEROĞLU\t[16]\t\tHamza Can TEKİN   [30]");
                Console.WriteLine("\n\tKDA-_->>>1,52\t\t\tKDA-_->>>Nan");
                System.Threading.Thread.Sleep(5000);
                goto c;
            }
            if (a == "Bursa E-spor")
            {
                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine("\tBursa E-spor");
                Console.WriteLine("\n");
                Console.WriteLine("\tVitra`BES\t\t\tRos`BES");
                Console.WriteLine("\n\tFurkan ADIGÜZEL\t[23]\t\tBerkant Başak   [21]");
                Console.WriteLine("\n\tKDA-_->>>1,48\t\t\tKDA-_->>>1,35");
                Console.WriteLine("\n");
                Console.WriteLine("\tTheCady`BES\t\t\tForza`BES");
                Console.WriteLine("\n\tErtuğrul KOÇ\t[21]\t\tDoğukan ÖZTEKİN   [21]");
                Console.WriteLine("\n\tKDA-_->>>1,39\t\t\tKDA-_->>>1,28");
                Console.WriteLine("\n");
                Console.WriteLine("\tScrew`BES\t\t\tNATOTAN`BES");
                Console.WriteLine("\n\tOkan SÖMEN\t[24]\t\tKerim KARATAŞ   [19]");
                Console.WriteLine("\n\tKDA-_->>>1,24\t\t\tKDA-_->>>Nan");
                Console.WriteLine("\n");
                Console.WriteLine("\tW4DE`BES");
                Console.WriteLine("\n\tMurat GÜRKAN\t[24]");
                Console.WriteLine("\n\tKDA-_->>>NaN");
                System.Threading.Thread.Sleep(5000);
                goto c;
            }
            if (a == "Çamlıca E-spor")
            {
                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine("\tÇamlıca E-spor");
                Console.WriteLine("\n");
                Console.WriteLine("\tCM`Felarcone\t\t\tCM`BeQuu");
                Console.WriteLine("\n\tBirkan AŞÇI\t[29]\t\tBatuhan DERELİOĞLU   [26]");
                Console.WriteLine("\n\tKDA-_->>>0,90\t\t\tKDA-_->>>1,16");
                Console.WriteLine("\n");
                Console.WriteLine("\tCM`Always\t\t\tCM`HusReiss");
                Console.WriteLine("\n\tMehmet ÖRSKIRAN\t[21]\t\tCan Hüseyin BALKAYA   [21]");
                Console.WriteLine("\n\tKDA-_->>>1,24\t\t\tKDA-_->>>1,07");
                Console.WriteLine("\n");
                Console.WriteLine("\tCM`Razorcone\t\t\tCM`Rainq");
                Console.WriteLine("\n\tKaan ARSLAN\t[20]\t\tVolkan AKÇA   [23]");
                Console.WriteLine("\n\tKDA-_->>>1,24\t\t\tKDA-_->>>1,06");
                Console.WriteLine("\n");
                Console.WriteLine("\tCM`Scooby");
                Console.WriteLine("\n\tSüleyman KÖKSAL\t[28]");
                Console.WriteLine("\n\tKDA-_->>>NaN");
                System.Threading.Thread.Sleep(5000);
                goto c;
            }
            if (a == "Gamers of Future")
            {
                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine("\tGamers of Future");
                Console.WriteLine("\n");
                Console.WriteLine("\tGOF`Salvio\t\t\tGOF`Quadro");
                Console.WriteLine("\n\tUmutcan ŞENOCAK\t[21]\t\tTugay AKAYDIN   [27]");
                Console.WriteLine("\n\tKDA-_->>>1,03\t\t\tKDA-_->>>0,93");
                Console.WriteLine("\n");
                Console.WriteLine("\tGOF`Nadz1\t\t\tGOF`Jaxis");
                Console.WriteLine("\n\tAbdullah AYGÜL\t[22]\t\tMuhittin EREN   [25]");
                Console.WriteLine("\n\tKDA-_->>>0,86\t\t\tKDA-_->>>1,01");
                Console.WriteLine("\n");
                Console.WriteLine("\tGOF`Fredy\t\t\tGOF`Kresha");
                Console.WriteLine("\n\tFatih ÇELEBİ\t[20]\t\tAlperen ÖZFİDAN   [23]");
                Console.WriteLine("\n\tKDA-_->>>0,93\t\t\tKDA-_->>>0,94");
                Console.WriteLine("\n");
                Console.WriteLine("\tGOF`Tequu");
                Console.WriteLine("\n\tAhmet Enes BACAKSIZ\t[24]");
                Console.WriteLine("\n\tKDA-_->>>1,11");
                System.Threading.Thread.Sleep(5000);
                goto c;
            }
            if (a == "Galatasaray")
            {
                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine("\tGalatasaray");
                Console.WriteLine("\n");
                Console.WriteLine("\tGS`MachineX\t\t\tGS`Camel");
                Console.WriteLine("\n\tEmirhan DEMİRBAŞ   [23]\t\tDoğukan DEMİR   [23]");
                Console.WriteLine("\n\tKDA-_->>>1,27\t\t\tKDA-_->>>NaN");
                Console.WriteLine("\n");
                Console.WriteLine("\tGS`Kenz\t\t\t\tGS`Flint");
                Console.WriteLine("\n\tYusuf ÜNAL\t[26]\t\tÖmer Faruk ÇAKIR   [23]");
                Console.WriteLine("\n\tKDA-_->>>1,45\t\t\tKDA-_->>>1,06");
                Console.WriteLine("\n");
                Console.WriteLine("\tGS`Woody\t\t\tGS`Flash");
                Console.WriteLine("\n\tOğuz KAYA\t[25]\t\tOğuzhan AKTAŞ   [23]");
                Console.WriteLine("\n\tKDA-_->>>1,11\t\t\tKDA-_->>>1,25");
                Console.WriteLine("\n");
                Console.WriteLine("\tGS`Ritual\t\t\tGS`APG");
                Console.WriteLine("\n\tAlper ARICAN\t[19]\t\tBünyamin AKYÜZ   [20]");
                Console.WriteLine("\n\tKDA-_->>>NaN\t\t\tKDA-_->>>1,24");
                System.Threading.Thread.Sleep(5000);
                goto c;
            }
            if (a == "Fastpay Wildcats")
            {
                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine("\tFastpay Wildcats");
                Console.WriteLine("\n");
                Console.WriteLine("\tFPW`Surprise\t\t\tFPW`Anarchy");
                Console.WriteLine("\n\tEge APAYDIN\t[22]\t\tKÜRŞAT ERTEM   [23]");
                Console.WriteLine("\n\tKDA-_->>>1,37\t\t\tKDA-_->>>1,43");
                Console.WriteLine("\n");
                Console.WriteLine("\tFPW`Shnazn\t\t\tFPW`Vons");
                Console.WriteLine("\n\tEge TARHAN\t[23]\t\tAYTEKİN YEŞBEK   [23]");
                Console.WriteLine("\n\tKDA-_->>>1,42\t\t\tKDA-_->>>1,42");
                Console.WriteLine("\n");
                Console.WriteLine("\tFPW`Koko\t\t\t\tFPW`RainLoX");
                Console.WriteLine("\n\tFatih YILDIZ\t[24]\t\tBatuhan KARABULUT   [23]");
                Console.WriteLine("\n\tKDA-_->>>1,67\t\t\tKDA-_->>>Nan");
                System.Threading.Thread.Sleep(5000);
                goto c;
            }
            if (a == "Dark Passage")
            {
                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine("\tDark Passage");
                Console.WriteLine("\n");
                Console.WriteLine("\tDP`Bukaki\t\t\tDP`claiN");
                Console.WriteLine("\n\tBatuhan YILMAZ \t[21]\t\tNihat SEFEROĞLU   [18]");
                Console.WriteLine("\n\tKDA-_->>>0,99\t\t\tKDA-_->>>1,00");
                Console.WriteLine("\n");
                Console.WriteLine("\tDP`Ressam\t\t\tDP`Shytlex");
                Console.WriteLine("\n\tMuhammet ÖZEN\t[21]\t\tOğuz HEKİMOĞLU   [18]");
                Console.WriteLine("\n\tKDA-_->>>0,81\t\t\tKDA-_->>>0,95");
                Console.WriteLine("\n");
                Console.WriteLine("\tDP`Rowdy\t\t\tDP`RaaVAs");
                Console.WriteLine("\n\tRamazan EKİNCİ\t[18]\t\tBedirhan AVCI   [28]");
                Console.WriteLine("\n\tKDA-_->>>1,01\t\t\tKDA-_->>>Nan");
                Console.WriteLine("\n");
                Console.WriteLine("\tDP`ptRNG\t\t\tDP`Ryrix");
                Console.WriteLine("\n\tNurullah BEKTAŞ\t[24]\t\tHasan KILINÇ   [18]");
                Console.WriteLine("\n\tKDA-_->>>NaN\t\t\tKDA-_->>>1,11");
                System.Threading.Thread.Sleep(5000);
                goto c;
            }
            if (a == "İstanbul E-spor")
            {
                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine("\tİstanbul E-spor");
                Console.WriteLine("\n");
                Console.WriteLine("\tİST`PickowN\t\t\tİST`taMMy");
                Console.WriteLine("\n\tEfe YORULMAZ\t[17]\t\tTamer TAHTALI   [20]");
                Console.WriteLine("\n\tKDA-_->>>1,31\t\t\tKDA-_->>>1,17");
                Console.WriteLine("\n");
                Console.WriteLine("\tİST`Berelpp\t\t\tİST`wmyg");
                Console.WriteLine("\n\tSamet YAKA\t[23]\t\tSezer ÇİTANAK   [20]");
                Console.WriteLine("\n\tKDA-_->>>1,21\t\t\tKDA-_->>>NaN");
                Console.WriteLine("\n");
                Console.WriteLine("\tİST`Aloysha\t\t\tİST`Mavera");
                Console.WriteLine("\n\tErsin KARATAŞ\t[23]\t\tErim ŞAŞAL   [24]");
                Console.WriteLine("\n\tKDA-_->>>1,06\t\t\tKDA-_->>>1,19");
                System.Threading.Thread.Sleep(5000);
                goto c;
            }
            if (a == "M0D-Z")
            {
                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine("\tM0D-Z");
                Console.WriteLine("\n");
                Console.WriteLine("\tCixEd`M0D\t\t\tWadaa`M0D");
                Console.WriteLine("\n\tHüseyin KIRAN\t[20]\t\tKerem UYSAL   [24]");
                Console.WriteLine("\n\tKDA-_->>>1,55\t\t\tKDA-_->>>NaN");
                Console.WriteLine("\n");
                Console.WriteLine("\tY4K7T`M0D\t\t\tMaxic`M0D");
                Console.WriteLine("\n\tYakut ERDOĞAN\t[22]\t\tFaruk Can ÖZTÜRK   [22]");
                Console.WriteLine("\n\tKDA-_->>>2,07\t\t\tKDA-_->>>1,46");
                Console.WriteLine("\n");
                Console.WriteLine("\tExtreme`M0D\t\t\tBrave`M0D");
                Console.WriteLine("\n\tMehmet Burak AKBALIK   [21]\tEren KASIRGA   [18]");
                Console.WriteLine("\n\tKDA-_->>>1,57\t\t\tKDA-_->>>1,64");
                System.Threading.Thread.Sleep(5000);
                goto c;
            }
            Console.WriteLine("\n\t");
            Console.WriteLine("Lütfen ZSL takım ismini eksiksiz yaz.(Takımlar: 1907 Fenerbahçe, Beşiktaş, Bursa E-spor, Çamlıca E-spor, Gamers\n\n\t\t of Future, Galatasatay, Fastpay Wildcats, Dark Passage, İstanbul E-spor, M0D-Z)...");
            System.Threading.Thread.Sleep(1500);
            goto b;
        c:
            Console.WriteLine("\n\t");
            Console.Write("Devam etmek için devam çıkmak için çıkış yaz-_->>>");
            d = Console.ReadLine();
            if (d == "devam" || d == "Devamke" || d == "Devam" || d == "devamke")
            {
                Console.WriteLine("\n\t");
                Console.WriteLine("Devamke...");
                System.Threading.Thread.Sleep(1500);
                goto b;
            }
            if (d == "çıkış" || d == "Çıkışke" || d == "Çıkış" || d == "çıkışke")
            {
                Console.WriteLine("\n\t");
                Console.WriteLine("Press any key to break...");
                System.Threading.Thread.Sleep(1500);
                goto e;
            }
            else
            {
                Console.WriteLine("\n\t");
                Console.WriteLine("Yanlış seçimke...");
                goto c;
            }
        e:
            Console.Read();
        }
    }
}
