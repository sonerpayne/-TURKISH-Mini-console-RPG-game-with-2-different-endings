using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Pratik12
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList envanter = new ArrayList();
            Timer zamanlayici = new Timer();
            zamanlayici.Interval = 5000;
            zamanlayici.Elapsed += konsolKapat;

            bool esya1 = false;
            bool esya2 = false;
            bool esya3 = false;
            int can = 3;
            bool kankaybi = false;
            bool saldiriKontrol = false;
            string saldiri = "";
            Console.WriteLine("Bir ormandasın. Etraf karanlık ıssız. Yanında bir ev var.");
            Console.WriteLine("1: Etrafı ara");
            Console.WriteLine("2: Eve gir");
            string anaSecim1 = Console.ReadLine();
            if (anaSecim1 == "1")
            {
                Console.Clear();
                Console.WriteLine("Etrafı arıyorsun...");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Üstünde kan olan bir bıçak buldun.");
                Console.WriteLine("1: Al");
                Console.WriteLine("2: Alma");
                string secim1 = Console.ReadLine();
                if (secim1 == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Bıçağı aldın ve eve doğru ilerliyorsun.");
                    envanter.Add("Kanlı bıçak");
                    esya1 = true;
                    System.Threading.Thread.Sleep(3000);
                    EveGir();
                }
                else if (secim1 == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Bıçağı almadan eve doğru ilerliyorsun...");
                    System.Threading.Thread.Sleep(3000);
                    EveGir();
                }
            }
            else if (anaSecim1 == "2")
            {
                EveGir();
            }
            Console.WriteLine("1: Oturup neler olduğunu hatırlamaya çalış");
            Console.WriteLine("2: Etrafı ara");
            string anaSecim2 = Console.ReadLine();
            if (anaSecim2 == "1")
            {
                Console.Clear();
                Console.WriteLine("Yanındaki koltuğa oturdun ve en son ne olduğunu hatırlamaya çalışıyorsun...");
                System.Threading.Thread.Sleep(4000);
                Console.WriteLine("En son arkadaşlarınla sahilde olduğunu hatırladın");
                Console.WriteLine("1: Ayağı kalk ve etrafı ara");
                Console.WriteLine("2: Biraz daha düşün");
                string secim2 = Console.ReadLine();
                if (secim2 == "1")
                {
                    Console.Clear();
                    EtrafiAra();
                }
                else if (secim2 == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Hiçbir şey hatırlayamadın.");
                }
            }
            else if (anaSecim2 == "2")
            {
                Console.Clear();
                EtrafiAra();
            }
            Console.WriteLine("Evin bir üst katı olduğunu fark ettin");
            Console.WriteLine("1: Üst kata çık");
            Console.WriteLine("2: Uyu ve sabahı bekle");
            string anaSecim3 = Console.ReadLine();
            if (anaSecim3 == "1")
            {
                Console.Clear();
                Console.WriteLine("Üst Kata çıkıyorsun...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Üst kata çıktın.");
                Console.WriteLine("1: Sağındaki odaya gir");
                Console.WriteLine("2: Solundaki odaya gir");
                string secim4 = Console.ReadLine();
                if (secim4 == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Sağındaki odaya giriyorsun...");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Yerde kanlar içinde yatan arkadaşını buldun. Yanında bir not var");
                    Console.WriteLine("1: Notu oku");
                    Console.WriteLine("2: Aşağı koşup ev telefonu ile polisi ara");
                    string altSecim = Console.ReadLine();
                    if (altSecim == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("NOT: ");
                        Console.WriteLine("Kontrolümde değil, üzgünüm payne, bunu yapmak istemezdim...");
                        System.Threading.Thread.Sleep(1000);
                        PolisiAra();
                    }
                    else if (altSecim == "2")
                    {
                        Console.Clear();
                        PolisiAra();
                    }
                }
                else if (secim4 == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Solundaki odaya giriyorsun...");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Bir not buldun.");
                    Console.WriteLine("NOT: Belki de hepsi rüyadır...");
                    System.Threading.Thread.Sleep(1000);
                    PolisiAra();
                }
            }
            else if (anaSecim3 == "2")
            {
                Console.Clear();
                Uyu();
            }
            //uyandın
            Console.WriteLine("1: Gece karanlık olan alanları ara");
            Console.WriteLine("2: Telefonu tamir etmek için kablo ara");
            string anaSecim4 = Console.ReadLine();
            if (anaSecim4 == "1")
            {
                EtrafiAra2();
            }
            else if (anaSecim4 == "2")
            {
                BodrumKataIn();
            }
            Console.WriteLine("Gerekli kabloları buldun ve kabloların yanında eski buruşmuş bir not var.");
            Console.WriteLine("1: Oku");
            Console.WriteLine("2: Telefonu tamir edip polisi ara");
            string anaSecim5 = Console.ReadLine();
            if (anaSecim5 == "1")
            {
                Console.Clear();
                Console.WriteLine("NOT:");
                Console.WriteLine("Oğlum, seni çok seviyorum. Eğer olur da bir gün bu notu bulursan");
                Console.WriteLine("benim için üzülme. Yine krize girdin. Üzerine kapıyı kilitledim.");
                Console.WriteLine("Teyzene sana 'bize bir şey olursa trafik kazasında öldüler de' demesini söyledim.");
                Console.WriteLine("Küçüklüğünde babanın bana uyguladığı şiddet yüzünden bir travma geçirdin. Ani krizlere girip");
                Console.WriteLine("Kontrolü kaybediyorsun ve bir süre sonra her şeyi unutuyorsun. Eğer bana bir şey olursa bunun");
                Console.WriteLine("sebebi sen değilsin oğlum. Seni seviyorum -Annen");
                System.Threading.Thread.Sleep(15000);
                Console.WriteLine("Oturdun ve ağlıyorsun.");
                Son();
            }
            else if (anaSecim5 == "2")
            {
                AltSon();
            }


            void EveGir()
            {
                Console.Clear();
                Console.WriteLine("Eve girdin.");
            }
            void EtrafiAra()
            {
                Console.Clear();
                Console.WriteLine("Etrafı arıyorsun...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Ailenle olan bir fotoğrafını buldun");
                Console.WriteLine("1: Al");
                Console.WriteLine("2: Alma");
                string al2 = Console.ReadLine();
                if (al2 == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Fotoğrafı aldın ve odaya geri döndün");
                    envanter.Add("Aile fotoğrafı");
                    esya2 = true;
                }
                else if (al2 == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Odaya geri döndün");
                }
            }
            void EtrafiAra2()
            {
                Console.Clear();
                KanKaybi();
                Console.WriteLine("Etrafı arıyorsun...");
                System.Threading.Thread.Sleep(2000);
                KabloAra();
                Console.WriteLine("Başka bir arkadaşının daha cesedini buldun ve yanında not var");
                Console.WriteLine("Artık bu durumdan canın sıkılmış durumda ve bir an önce bitmesini istiyorsun.");
                Console.WriteLine("Notu aldın.");
                System.Threading.Thread.Sleep(900);
                Console.WriteLine("NOT: ");
                Console.WriteLine("Tüm bunları neden yaptığımı bilmiyorum... Tek bildiğim hoşuma gittiği. Bu sonuncusuydu");
                Console.WriteLine("Eğer bu notu bulduysan, bodrum kata git, oraya telefon için gerekli kabloları koydum.");
                Console.WriteLine("Polisi arayıp tüm bunların neden olduğunu bilmediğini söyle. Daha yapacaklarımız var ;)");
                System.Threading.Thread.Sleep(7000);
                BodrumKataIn();
            }
            void BodrumKataIn()
            {
                Console.WriteLine("Bodrum kata iniyorsun...");
                System.Threading.Thread.Sleep(3000);
            }
            void KabloAra()
            {
                Console.Clear();
                KanKaybi();
                if (kankaybi == true)
                {
                    Console.WriteLine("Etrafı aradın ve sağlık paketi buldun. Yaranı iyileştiriyorsun. ");
                    kankaybi = false;
                    System.Threading.Thread.Sleep(3000);
                }
            }
            void PolisiAra()
            {
                Console.WriteLine("Polisi aramak için aşağı iniyorsun");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Telefon çalışmadı ve panik halindesin");
                Console.WriteLine("1: Dışarı çık ve etrafı ara");
                Console.WriteLine("2: Uyu ve sabahı bekle");
                string polisecim = Console.ReadLine();
                if (polisecim == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Dışarı çıktın ve bir araba gördün.");
                    Console.WriteLine("Arabaya doğru ilerliyorsun...");
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("Ağaçların arasında bir kurt sana atladı.");
                    Console.WriteLine("Karşı koymak için 5 Saniyen var.");
                    if (esya1 == true)
                    {
                        Console.WriteLine("ENTER: Bıçağını kullanarak kurtu öldür.");
                    }
                    else if (esya1 != true)
                    {
                        Console.WriteLine("ENTER: Kurtu boğmaya çalış.");
                    }
                    zamanlayici.Start();
                    saldiri = Console.ReadLine();
                    if (saldiri == "" && esya1 == true)
                    {
                        zamanlayici.Stop();
                        Console.Clear();
                        Console.WriteLine("Saldırıdan yara almadan kurtuldun.");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("Arabanın kanlı olduğunu fark ettin.");
                        Console.WriteLine("1: Arabayı incele");
                        Console.WriteLine("2: Eve dön ve uyu");
                        string arabaSecim = Console.ReadLine();
                        if (arabaSecim == "1")
                        {
                            Console.Clear();
                            KanKaybi();
                            Console.WriteLine("Arabayı inceliyorsun...");
                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine("Diğer arkadaşını da ölü buldun ve yanında bir not var");
                            Console.WriteLine("NOT:");
                            Console.WriteLine("Her ne kadar geçici olsa da, andan zevk almaya başlıyorum...");
                            System.Threading.Thread.Sleep(3000);
                            Console.WriteLine("Uyumak ve her şeyi anlamaya çalışmak için eve dönüyorsun...");
                            System.Threading.Thread.Sleep(3000);
                            Uyu();

                        }
                        else if (arabaSecim == "2")
                        {
                            Console.Clear();
                            KanKaybi();
                            Console.WriteLine("Eve dönüyorsun...");
                            System.Threading.Thread.Sleep(1500);
                            Uyu();
                        }
                    }
                    else if (saldiri == "" && esya1 != true)
                    {
                        zamanlayici.Stop();
                        Console.Clear();
                        Console.WriteLine("Saldırıdan kurtuldun ama yaralandın.");
                        kankaybi = true;
                        Console.WriteLine("Kan kaybetmeye başlıyorsun. Akıllıca seçimler yap.");
                        Console.WriteLine("Eve geri dönüyorsun...");
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine("Karanlıkta iyileşmek için yardım malzemesi aradın ama bulamadın. Uyumaya gidiyorsun...");
                        System.Threading.Thread.Sleep(2000);
                        Uyu();
                    }
                }
                else if (polisecim == "2")
                {
                    Uyu();
                }
            }
            void Uyu()
            {
                Console.Clear();
                Console.WriteLine("Sabah oldu ve etrafı seçebiliyorsun.");
                Console.WriteLine("İçinde olduğun ev ailenin tatil için geldiği ev.");
            }
            void KanKaybi()
            {
                if (kankaybi == true)
                {
                    can--;
                    if (can == 0)
                    {
                        Console.Clear();
                        Environment.Exit(0);
                    }
                }
            }
            void AltSon()
            {
                System.Threading.Thread.Sleep(300);
                Console.WriteLine("Telefonu tamir ettin ve polisi aradın. Polise her şeyi anlattın ve seni tek hücreli");
                Console.WriteLine("hapishaneye koydular.");
                Console.WriteLine("");
                Console.WriteLine("Polis olayı araştırdı ve bazı şeyleri açığa çıkardı. Senin küçükken ailevi olaylardan");
                Console.WriteLine("dolayı travma geçirdiğini ve bu yüzden ani sinir krizlerine girdiğini öğrendiler.");
                Console.WriteLine("Küçükken kaybettiğin anneni de bu sinir krizleri yüzünden sen öldürmüşsün ve teyzen sana");
                Console.WriteLine("annenin trafik kazasında öldüğünü söylemiş.");
                System.Threading.Thread.Sleep(15000);
                Console.Clear();
                Console.WriteLine("Son.");
                System.Threading.Thread.Sleep(2000);
                Environment.Exit(0);
            }
            void Son()
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Yerde bir silah gördün ve intihar etmeye karar verdin.");
                Console.WriteLine("Kafana sıkıp hayatına son verdin. Evi kontrol etmeye gelen teyzen cesedini buldu");
                Console.WriteLine("ve polisi aradı.");
                System.Threading.Thread.Sleep(10000);
                Console.Clear();
                Console.WriteLine("Son.");
                System.Threading.Thread.Sleep(2000);
                Environment.Exit(0);
            }
            Console.ReadLine();
        }
        static void konsolKapat(object source, System.Timers.ElapsedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

//array list ile envanter sistemi
//envantere eşya ekleme
//uygun eşyalarla uygun şeyler yapabilme
