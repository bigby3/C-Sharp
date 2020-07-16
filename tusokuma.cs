          // CHAR İLE KARAKTER OKUTMA
          
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Write("Bir tuşa basarak ardından enter'a basınız:");
            char karakter = (char)Console.Read();
            Console.WriteLine("Basılan tuş:"+karakter);
            Console.ReadLine();
            
            
           // HER TUŞU OKUYABİLMEK İÇİN CONSOLEKEYINFO YAPISI KULLANILIR.(f1,enter,spacebar)
              
            Console.WriteLine("Bir tuşa basınız:");
            System.ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            Console.WriteLine(KeyInfo.Key.ToString() + " tuşuna bastınız");
            Console.ReadLine();
            
             //f2 ye basınca ad soyadı ekranı yazdıran ya da esc ye basarak çıkıs sağlayan program
            Console.WriteLine("Adınızı girin:");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı girin:");
            string soyad = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ekrana yazdırmak için f2 çıkmak için esc'ye basınız.");
            System.ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            if (KeyInfo.Key==ConsoleKey.Escape)
            {
                System.Environment.Exit(0);
            }
            else if (KeyInfo.Key==ConsoleKey.F2)
            {
                Console.Write(ad + " " + soyad);
                Console.ReadKey();
            }
            Console.ReadLine();
            
            
            
         // CTRL,ALT VE SHIFT TUSLARINI ALGILAMAK İÇİN CONSOLEKEYINFO YAPISININ MODİFİERS ÖZELLİĞİ KULLANILIR
                        
            Console.TreatControlCAsInput = true;
            Console.WriteLine("Bir tuşa basınız.");
            System.ConsoleKeyInfo KeyInfo = Console.ReadKey();
            if ((KeyInfo.Modifiers & ConsoleModifiers.Alt)!=0)
                Console.Write("ALT+");
            if ((KeyInfo.Modifiers & ConsoleModifiers.Shift) != 0)
                Console.Write("SHIFT+");
            if ((KeyInfo.Modifiers & ConsoleModifiers.Control) != 0) ;
            Console.Write("CTRL+");
            Console.WriteLine(KeyInfo.Key.ToString() + "tuşuna bastınız");
