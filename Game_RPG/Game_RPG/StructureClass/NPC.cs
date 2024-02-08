using System;

namespace Game_RPG.StructureClass
{
    class NPC
    {
        public static void Smithy_Blacksmith(string NPC_Choose)
        {
            switch (NPC_Choose)
            {
                case "witaj":
                    {
                        Console.WriteLine("\t\t\tWitaj w mojej kużni \"Skibidi Toilet\" \n\n");
                        Console.WriteLine("Witaj na moim bagnie {0}\n", Program.Player.Name_Character);
                        Console.WriteLine("[1] Kup");
                        Console.WriteLine("[2] Porozmawiaj");
                        Console.WriteLine("[3] Wyjśćie\n");
                        Console.Write("Czy chciałbyś coś kupic? Może Pogadać?: ");
                    }
                    break;

                case "welcome":
                    {
                        Console.WriteLine("\t\t\tWelcome to my Smithy \"Skibidi Toilet\" \n\n");
                        Console.WriteLine("Welcome to my swamp {0}\n", Program.Player.Name_Character);
                        Console.WriteLine("[1] Buy");
                        Console.WriteLine("[2] Let's talk");
                        Console.WriteLine("[3] Exit\n");
                        Console.Write("Would you like to buy something? Maybe Talk?: ");
                    }
                    break;

                case "rozmowa":
                    {
                        Random random = new();
                        int Store_Salesman_Text = random.Next(1, 6);
                        switch (Store_Salesman_Text)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Słyszałeś o Lochach Belziego? Podobno nikt jeszcze nieośmielił się tam wejść, mają tam czekać wielkie skarby.");
                                    Console.ReadLine();
                                }
                                break;

                            case 2:
                                {
                                    Console.WriteLine("Oaza to piękne miejsce, a jego wody mają uzdrawiającą moc leczenia ran.");
                                    Console.ReadLine();
                                }
                                break;

                            case 3:
                                {
                                    Console.WriteLine("Od dawna nie słyszałem aby ktoś sie zapuszczał do Jaskini Behemota, wielu już próbowało pokonać tego strasznego Demona.");
                                    Console.ReadLine();
                                }
                                break;

                            case 4:
                                {
                                    Console.WriteLine("Podobno na południowym zachodzie znajduje się dziwna jaskinia, podobno została odkryta przypadkiem przez Maga Trosika.");
                                    Console.ReadLine();
                                }
                                break;

                            case 5:
                                {
                                    Console.WriteLine("Zjadłym trochę mięsa Wilka, po odpowiednim obrobieniu jego smak jest niedoopisania.");
                                    Console.ReadLine();
                                }
                                break;
                        }
                    }
                    break;

                case "talk":
                    {
                        Random random = new();
                        int Store_Salesman_Text = random.Next(1, 6);
                        switch (Store_Salesman_Text)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Have you heard of Belzi's Dungeon? Apparently no one has dared to go there yet, there are great treasures waiting there.");
                                    Console.ReadLine();
                                }
                                break;

                            case 2:
                                {
                                    Console.WriteLine("The oasis is a beautiful place and its waters have the healing power to heal wounds.");
                                    Console.ReadLine();
                                }
                                break;

                            case 3:
                                {
                                    Console.WriteLine("I haven't heard of anyone venturing into the Behemoth Cave for a long time, many have already tried to defeat this terrible Demon..");
                                    Console.ReadLine();
                                }
                                break;

                            case 4:
                                {
                                    Console.WriteLine("Apparently there is a strange cave in the southwest, supposedly discovered by accident by the Mage Trosik.");
                                    Console.ReadLine();
                                }
                                break;

                            case 5:
                                {
                                    Console.WriteLine("I would eat some Wolf meat, once properly processed its taste is indescribable.");
                                    Console.ReadLine();
                                }
                                break;
                        }
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Error");
                    }
                    break;
            }
        }

        public static void Armorers_Workshop(string NPC_Choose)
        {
            switch (NPC_Choose)
            {
                case "witaj":
                    {
                        Console.WriteLine("\t\t\tWitaj w moim warsztacie \"Pancerzowa Fantazja\" \n\n");
                        Console.WriteLine("Witaj na moim bagnie {0}\n", Program.Player.Name_Character);
                        Console.WriteLine("[1] Kup");
                        Console.WriteLine("[2] Porozmawiaj");
                        Console.WriteLine("[3] Wyjśćie\n");
                        Console.Write("Czy chciałbyś coś kupic? Może Pogadać?: ");
                    }
                    break;

                case "welcome":
                    {
                        Console.WriteLine("\t\t\tWelcome to my Workshop \"Armor Fantasy\" \n\n");
                        Console.WriteLine("Welcome to my swamp {0}\n", Program.Player.Name_Character);
                        Console.WriteLine("[1] Buy");
                        Console.WriteLine("[2] Let's talk");
                        Console.WriteLine("[3] Exit\n");
                        Console.Write("Would you like to buy something? Maybe Talk?: ");
                    }
                    break;

                case "rozmowa":
                    {
                        Random random = new();
                        int Store_Salesman_Text = random.Next(1, 7);
                        switch (Store_Salesman_Text)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Twoja stara zbroja już leciwa? Wprowadzę ją w nową erę.");
                                    Console.ReadLine();
                                }
                                break;

                            case 2:
                                {
                                    Console.WriteLine("Chociaż jestem kowalem, a nie wróżbitą, twarz twoja mówi mi, że potrzebujesz nowego pancerza.");
                                    Console.ReadLine();
                                }
                                break;

                            case 3:
                                {
                                    Console.WriteLine("Zabójcza zbroja czy zwykła? Wybierz, a ja zrobię resztę!");
                                    Console.ReadLine();
                                }
                                break;

                            case 4:
                                {
                                    Console.WriteLine("Każdy pancerz to jak opowieść. Jaką historię chcesz nosić?");
                                    Console.ReadLine();
                                }
                                break;

                            case 5:
                                {
                                    Console.WriteLine("Mój najnowszy wynalazek: Zbroja do jedzenia popcornu. Idealna na maratony filmowe!");
                                    Console.ReadLine();
                                }
                                break;

                            case 6:
                                {
                                    Console.WriteLine("Jeśli twoja zbroja nie świeci w ciemności, to jesteś tylko połowicznie gotowy do przygód!");
                                    Console.ReadLine();
                                }
                                break;
                        }
                    }
                    break;

                case "talk":
                    {
                        Random random = new();
                        int Store_Salesman_Text = random.Next(1, 7);
                        switch (Store_Salesman_Text)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Is your old armor wearing out? I will bring her into a new era.");
                                    Console.ReadLine();
                                }
                                break;

                            case 2:
                                {
                                    Console.WriteLine("Even though I am a blacksmith and not a fortune teller, your face tells me that you need new armor.");
                                    Console.ReadLine();
                                }
                                break;

                            case 3:
                                {
                                    Console.WriteLine("Deadly armor or regular armor? Choose and I'll do the rest!");
                                    Console.ReadLine();
                                }
                                break;

                            case 4:
                                {
                                    Console.WriteLine("Each armor is like a story. What story do you want to carry?");
                                    Console.ReadLine();
                                }
                                break;

                            case 5:
                                {
                                    Console.WriteLine("My newest invention: Popcorn eating armor. Perfect for movie marathons!");
                                    Console.ReadLine();
                                }
                                break;

                            case 6:
                                {
                                    Console.WriteLine("If your armor doesn't glow in the dark, you're only halfway ready for adventure!");
                                    Console.ReadLine();
                                }
                                break;
                        }
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Error");
                    }
                    break;
            }
        }

        public static void Forest_Elder_Axsi(string NPC_Choose)
        {
            switch (NPC_Choose)
            {
                case "witaj":
                    {
                        Console.WriteLine("\t\t\tWelcome to Axsi's Drug Haven!\n\n");
                        Console.WriteLine("Witaj na moim bagnie {0}\n", Program.Player.Name_Character);
                        Console.WriteLine("[1] Kup");
                        Console.WriteLine("[2] Porozmawiaj");
                        Console.WriteLine("[3] Wyjśćie\n");
                        Console.Write("Czy chciałbyś coś kupic? Może Pogadać?: ");
                    }
                    break;

                case "welcome":
                    {
                        Console.WriteLine("\t\t\tWelcome to Axsi's Drug Haven!\n\n");
                        Console.WriteLine("Welcome to my swamp {0}\n", Program.Player.Name_Character);
                        Console.WriteLine("[1] Buy");
                        Console.WriteLine("[2] Let's talk");
                        Console.WriteLine("[3] Exit\n");
                        Console.Write("Would you like to buy something? Maybe Talk?: ");
                    }
                    break;

                case "rozmowa":
                    {
                        Random random = new();
                        int Store_Salesman_Text = random.Next(1, 10);
                        switch (Store_Salesman_Text)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Ach, pozdrawiam! Dotarłeś do Alchemicznej Oazy Axsi. Jaki napar mogę dziś dla Ciebie ugotować?");
                                    Console.ReadLine();
                                }
                                break;

                            case 2:
                                {
                                    Console.WriteLine("Piwna Przystań Axsi czeka! Gdzie warzone są mikstury z odrobiną magii i szczyptą tajemniczości.");
                                    Console.ReadLine();
                                }
                                break;

                            case 3:
                                {
                                    Console.WriteLine("Witaj, podróżniku! Odkryj ziołową przystań Axsi, aby znaleźć środki, o których istnieniu nie wiedziałeś, że ich potrzebujesz.");
                                    Console.ReadLine();
                                }
                                break;

                            case 4:
                                {
                                    Console.WriteLine("Wejdź prosto do Pawilonu Eliksirów Axsi! Eliksiry na każdą dolegliwość i mikstury na każdą sytuację.");
                                    Console.ReadLine();
                                }
                                break;

                            case 5:
                                {
                                    Console.WriteLine("Wejdź do Raju Eliksirów Axsi! Najlepsze mikstury po tej stronie królestwa!");
                                    Console.ReadLine();
                                }
                                break;

                            case 6:
                                {
                                    Console.WriteLine("Wejdź prosto do Pawilonu Eliksirów Axsi! Gwarantujemy, że nasze mikstury są w 110% magiczne lub odzyskasz złoto!");
                                    Console.ReadLine();
                                }
                                break;

                            case 7:
                                {
                                    Console.WriteLine("Pozdrawiam, przyjacielu! Alchemiczna Oaza Axsi: Bo kto potrzebuje zwykłej wody, skoro można mieć zaczarowaną wodę?");
                                    Console.ReadLine();
                                }
                                break;

                            case 8:
                                {
                                    Console.WriteLine("Cześć cześć! Ziołowa Przystań Axsi: Czasem najlepszym lekarstwem jest dobry śmiech... i magiczne zioło lub dwa.");
                                    Console.ReadLine();
                                }
                                break;

                            case 9:
                                {
                                    Console.WriteLine("Wejdź prosto do Pawilonu Eliksirów Axsi! Mamy eliksiry tak potężne, że nawet duchy nie mogą się oprzeć łykowi!");
                                    Console.ReadLine();
                                }
                                break;
                        }
                    }
                    break;

                case "talk":
                    {
                        Random random = new();
                        int Store_Salesman_Text = random.Next(1, 6);
                        switch (Store_Salesman_Text)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Ah, greetings! You've entered Axsi's Alchemical Oasis. What brew can I concoct for you today?");
                                    Console.ReadLine();
                                }
                                break;

                            case 2:
                                {
                                    Console.WriteLine("Axsi's Brew Haven awaits! Where potions are brewed with a touch of magic and a sprinkle of mystery.");
                                    Console.ReadLine();
                                }
                                break;

                            case 3:
                                {
                                    Console.WriteLine("Hello there, traveler! Explore Axsi's Herbal Haven for the remedies you never knew you needed.");
                                    Console.ReadLine();
                                }
                                break;

                            case 4:
                                {
                                    Console.WriteLine("Step right up to Axsi's Potion Pavilion! Elixirs for every ailment and potions for every predicament.");
                                    Console.ReadLine();
                                }
                                break;

                            case 5:
                                {
                                    Console.WriteLine("Step into Axsi's Potion Paradise! The finest concoctions this side of the realm!");
                                    Console.ReadLine();
                                }
                                break;

                            case 6:
                                {
                                    Console.WriteLine("Step right up to Axsi's Potion Pavilion! We guarantee our potions are 110% magical or your gold back!");
                                    Console.ReadLine();
                                }
                                break;

                            case 7:
                                {
                                    Console.WriteLine("Greetings, friend! Axsi's Alchemical Oasis: Because who needs regular water when you can have enchanted water?");
                                    Console.ReadLine();
                                }
                                break;

                            case 8:
                                {
                                    Console.WriteLine("Hello, hello! Axsi's Herbal Haven: Because sometimes the best medicine is a good laugh... and a magical herb or two.");
                                    Console.ReadLine();
                                }
                                break;

                            case 9:
                                {
                                    Console.WriteLine("Step right up to Axsi's Potion Pavilion! We've got potions so powerful, even the ghosts can't resist a sip!");
                                    Console.ReadLine();
                                }
                                break;
                        }
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Error");
                    }
                    break;
            }
        }

        public static void Adventurers_Guild(string NPC_Choose)
        {
            switch (NPC_Choose)
            {
                case "witaj":
                    {
                        Console.WriteLine("Witaj w Gildii Poszukiwaczy przygód!\n\n");
                        Console.WriteLine(
                            "[1] Pokaż mi listę zadań\n" +
                            "[2] Wykonałem zadanie\n" +
                            "[3] Zamień Trofea na Złoto\n" +
                            "[4] Porozmawiaj\n" +
                            "[5] Wyjśćie\n");
                        Console.Write("Co potrzeba?: ");
                    }
                    break;

                case "welcome":
                    {
                        Console.WriteLine("Welcome to the Adventurers' Guild!\n\n");
                        Console.WriteLine(
                            "[1] Show me your to-do list\n" +
                            "[2] I completed the task\n" +
                            "[3] Convert Trophies to Gold\n" +
                            "[4] Let's talk\n" +
                            "[5] Exit\n");
                        Console.Write("What you need?: ");
                    }
                    break;

                case "rozmowa":
                    {
                        Random random = new();
                        int Store_Salesman_Text = random.Next(1, 9);
                        switch (Store_Salesman_Text)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Dziękujemy za udział w ostatniej misji! Wasza odwaga i determinacja zawsze nas inspiruje. Pamiętajcie, że razem możemy pokonać każde wyzwanie.");
                                    Console.ReadLine();
                                }
                                break;

                            case 2:
                                {
                                    Console.WriteLine("Czy jesteś gotów na prawdziwe wyzwanie? Zbliża się czas, aby stanąć twarzą w twarz z potężnym smokiem, który ukrywa skarb głęboko w swojej jaskini.");
                                    Console.ReadLine();
                                }
                                break;

                            case 3:
                                {
                                    Console.WriteLine("Słyszałeś o legendarnym skarbie ukrytym w starym zamku? Może czas zebrać się i wyruszyć na poszukiwania! Jesteś może zainteresowany?");
                                    Console.ReadLine();
                                }
                                break;

                            case 4:
                                {
                                    Console.WriteLine("Hej, nowicjuszu! Mamy dla ciebie nowe zadanie. Słyszałem, że w pobliskim lesie pojawił się tajemniczy stwór. Czy dasz radę to sprawdzić?.");
                                    Console.ReadLine();
                                }
                                break;

                            case 5:
                                {
                                    Console.WriteLine("Witaj w naszej gildii! Tutaj zawsze panuje duch przygody. Zawsze możesz liczyć na pomoc i wsparcie innych członków.");
                                    Console.ReadLine();
                                }
                                break;

                            case 6:
                                {
                                    Console.WriteLine("Dzięki za wasze zaangażowanie w ostatniej misji! Jesteście prawdziwymi bohaterami gildii. Czekają nas jeszcze większe wyzwania, ale razem damy radę!");
                                    Console.ReadLine();
                                }
                                break;

                            case 7:
                                {
                                    Console.WriteLine("Słyszeliście o nieznanych tunelach pod miastem? Może warto tam się wybrać i odkryć, co się tam kryje. Kto jest gotów na nową przygodę?");
                                    Console.ReadLine();
                                }
                                break;

                            case 8:
                                {
                                    Console.WriteLine("Dzięki za waszą odwagę podczas ostatniej wyprawy! Jesteście sercem gildii. Niech wasza pasja nigdy nie gaśnie!");
                                    Console.ReadLine();
                                }
                                break;
                        }
                    }
                    break;

                case "talk":
                    {
                        Random random = new();
                        int Store_Salesman_Text = random.Next(1, 9);
                        switch (Store_Salesman_Text)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Thank you for participating in the last mission! Your courage and determination always inspire us. Remember that together we can overcome any challenge.");
                                    Console.ReadLine();
                                }
                                break;

                            case 2:
                                {
                                    Console.WriteLine("Are you ready for a real challenge? The time is drawing near to come face to face with a mighty dragon that hides treasure deep in its cave.");
                                    Console.ReadLine();
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine("Have you heard about the legendary treasure hidden in an old castle? Maybe it's time to get together and go exploring! Are you perhaps interested?");
                                    Console.ReadLine();
                                }
                                break;

                            case 4:
                                {
                                    Console.WriteLine("Hey, newbie! We have a new task for you. I heard that a mysterious creature appeared in the nearby forest. Can you check it?.");
                                    Console.ReadLine();
                                }
                                break;

                            case 5:
                                {
                                    Console.WriteLine("Welcome to our guild! There is always a spirit of adventure here. You can always count on the help and support of other members.");
                                    Console.ReadLine();
                                }
                                break;

                            case 6:
                                {
                                    Console.WriteLine("Thanks for your involvement in the last mission! You are the true heroes of the guild. Even greater challenges await us, but together we can do it!");
                                    Console.ReadLine();
                                }
                                break;

                            case 7:
                                {
                                    Console.WriteLine("Have you heard about unknown tunnels under the city? Maybe it's worth going there and discovering what's hidden there. Who's ready for a new adventure?");
                                    Console.ReadLine();
                                }
                                break;

                            case 8:
                                {
                                    Console.WriteLine("Thanks for your courage on the last expedition! You are the heart of the guild. May your passion never fade away!");
                                    Console.ReadLine();
                                }
                                break;
                        }
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Error");
                    }
                    break;
            }
        }
    }
}