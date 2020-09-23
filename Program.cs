using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            practiceSeven();

            //int a = 10;
            // Console.WriteLine("Variable before calling a method: " + a);
            // practiceSix(ref a);
            // Console.WriteLine("Variable after calling a method: " + a);

            // Wizard wizard01 = new Wizard("Parry Popper", "Expecto Rerolum");
            
            // wizard01.CastSpell();
            // wizard01.CastSpell();
            // wizard01.CastSpell();
            // wizard01.CastSpell();
            // wizard01.DrinkManaPotion();
            // wizard01.CastSpell();

            Console.ReadKey();
        }

        static void practiceOne()
        {
             Console.Title = "Int guesser";

            int guess = 0;
            int attempts = 0;

            Random random = new Random();
            int randNum = random.Next(1, 101);

            Console.WriteLine("You need to guess a random number between 1 and 100, start!");
            while (guess != randNum)
            {
                guess = Convert.ToInt32( Console.ReadLine() );

                if(guess < randNum)
                {
                    Console.WriteLine("Not enough!");
                    attempts++;
                } 
                else if (guess > randNum)
                {
                    Console.WriteLine("Too much!");
                    attempts++;
                }
            }

            Console.WriteLine("Congratulations! The number is " + randNum + "!");
            Console.WriteLine("You had " + attempts + " attempts!");
        }

        static void practiceTwo() // Arrays
        {
            int rank = 0;

            string[] movies = {
                "Big Bang Theory",
                "Gladiator",
                "How I met Your Mother",
                "Hobbit",
                "Harry Potter",
                "Lord of The Rings",
                "Lucifer"
            };

            string[] yourMovies = new string[5];

            for (int i = 0; i < movies.Length; i++)
            {
                rank = i+1;
                Console.WriteLine(rank + ". " + movies[i]);
            }

            Console.WriteLine("Those are my favorite movies and series, please, tell me your top five!");
            Console.WriteLine("");

            for (int i = 0; i < yourMovies.Length; i++)
            {
                yourMovies[i] = Console.ReadLine();
            }

            if(yourMovies[yourMovies.Length - 1] != movies[yourMovies.Length - 1])
            {
                Console.WriteLine("Wow, i love those movies, except " + yourMovies[yourMovies.Length - 1]);
            } 
            else 
            {
                Console.WriteLine("Wow, i love those movies!");
            }
            Console.WriteLine("");
            for (int i = 0; i < yourMovies.Length; i++)
            {
                rank = i+1;
                Console.WriteLine(rank + ". " + yourMovies[i]);
            }
        }
    
        static void practiceThree () //Mostly if statements
        {
            List<string> students = new List<string>();
            int classSize;

            Console.WriteLine("How many students do You have in Your class?");
            classSize = Convert.ToInt32( Console.ReadLine() );

            if(classSize > 1){
                Console.WriteLine("Please, input Your " + classSize + " students names here:");
            } else if (classSize == 1) {
                Console.WriteLine("Please, input Your student name here:");
            } else {
                Console.WriteLine("Excuse me, You can't have 0 or less students in class. In that case, You do not have any class!");
            }

            if(classSize > 0){
                for (int i = 0; i < classSize; i++) {
                students.Add( Console.ReadLine() );
                }

                students.Sort();

                Console.WriteLine("Okay, here is Your students list");
                Console.WriteLine("");

                for (int i = 0; i < students.Count; i++) {
                    Console.WriteLine((i+1) + ". " + students[i]);
                }
            }
        }
    
        static int practiceFour(string sentence)
        {
            int words = sentence.Split().Length;

            return words;
        }
    
        static void practiceFive() //Loops
         {
             int[] arrays = new int[10];

             for (int i = 0; i < arrays.Length; i++)
             {
                 arrays[i] = i;
             }

             foreach (int item in arrays)
             {
                 Console.WriteLine("I am in collection Array! " + arrays[1]);
             }

            int c = 0;
            while (c != arrays.Length)
            {
                Console.WriteLine("I'm in while loop!");
                c++;
            }

            c = 0;
            do 
            {
                Console.WriteLine("C variable is not equal to arrays.Length, and it will never be, but this piece of code is gonna work ONCE anyway!");
                c++;
            } while (c == arrays.Length);
            

         }
    
        static void practiceSix(ref int a)
        {
            a = 15;
            Console.WriteLine("Variable into method: " + a);
        }

        static void practiceSeven()
        {
            string name;
            int damage = 10;
            string weapon;

            string[] weapons =
            {
                "Huge Long Sword",
                "Sharp Short Sword",
                "Hugeass Axe",
                "B.F. Hammer"
            };

            Console.WriteLine("\nWelcome adventurer! \nPlease, tell me Your name!");
            name = Console.ReadLine();
            Console.WriteLine("\nAh yes! Welcome " + name + "!\nNow, choose one of those weapons to begin your journey:\n\n");

            for(int i=0; i < weapons.Length; i++)
            {
                Console.WriteLine(weapons[i]);
            }

            weapon = Console.ReadLine();

            switch (weapon)
            {
                case "Huge Long Sword":
                    damage += 20;
                    break;
                case "Sharp Short Sword":
                    damage += 15;
                    break;
                case "Hugeass Axe":
                    damage += 30;
                    break;
                case "B.F. Hammer":
                    damage += 25;
                    break;

                default:
                    damage += 0;
                    break;
            }
            Console.WriteLine("\n\nYour damage is: " + damage + "!");

            Console.WriteLine("\nYes! so " + weapon + " it is! \nWise choise adventurer");

            string[] city = {"Dal", "Moscow", "Rebecco", "Reven", "Romania", "Szczebrzeszyn"};
            Random randNum = new Random();

            Console.WriteLine("\nOh no!\nA " + city[randNum.Next(0, 6)] + "City needs Your help! \nQuickly! take Your weapon and go save them!");

            string[] enemy = {"Ghul", "Zombie", "Zombie Deer", "Gargoul", "Undead", "Skeleton"};
            string CurrentEnemy = enemy[randNum.Next(0, 6)];

            Console.WriteLine("\nAnd You did.\nWhen you left a palace, You saw a city covered in flames and blood.\nYou run to help as fast as You could, but five hot dogs for breakfast did it's job...\n");
            Console.ReadLine();
            Console.WriteLine("But finally, You slighlty made it. First thing You see is a horrible " + CurrentEnemy + " coming Your way!\nYou take " + weapon + " in hand and move forward\n");

            //Fight!

            int enemyLife = randNum.Next(20, 61);
            Console.WriteLine(enemyLife);
            string[] parts = {"Left leg", "Right Leg", "Torso", "Left hand", "Right hand", "Head"};

            CurrentEnemy = enemy[randNum.Next(0, 6)];

            while(enemyLife >= 0)
            {
                Console.WriteLine("\n" + CurrentEnemy + " is ready to fight. You attack first, choose where!\n");
                
                for (int i = 0; i < parts.Length; i++)
                {
                    Console.WriteLine(parts[i]);
                }

                string attack = Console.ReadLine();

                switch (attack)
                {
                    case "Left leg":
                    case "Right leg":
                        enemyLife -= randNum.Next(damage, Convert.ToInt32((damage * 1.1)));
                        break;
                    case "Left hand":
                    case "Right hand":
                        enemyLife -= randNum.Next(Convert.ToInt32((damage * 0.8)), Convert.ToInt32((damage * 1.2)));
                        break;
                    case "Torso":
                        enemyLife -= randNum.Next(Convert.ToInt32((damage * 0.5)), Convert.ToInt32((damage * 2)));
                        break;
                    case "Head":
                        enemyLife -= randNum.Next(0, Convert.ToInt32((damage * 3)));
                        break;

                    default:
                        enemyLife -= 0;
                        break;
                }

                Console.WriteLine("\n" + CurrentEnemy + " has " + enemyLife + " left!");
                if(enemyLife > 0){
                    Console.WriteLine("\n" + CurrentEnemy + " tries to hit You, but You dodged attack!");
                }
            }
            Console.WriteLine("\nCongratulations! " + CurrentEnemy + " died!");

            Console.WriteLine("Now, You have to leave city and go east and find a legendary Saint Granade");
            Console.ReadKey();
            Console.WriteLine("A few miles further you meet two mosters! You need to fight!");

            enemyLife = randNum.Next(20, 61);
            Console.WriteLine(enemyLife);

            while(enemyLife >= 0)
            {
                Console.WriteLine("\n" + CurrentEnemy + " is ready to fight. You attack first, choose where!\n");
                
                for (int i = 0; i < parts.Length; i++)
                {
                    Console.WriteLine(parts[i]);
                }

                string attack = Console.ReadLine();

                switch (attack)
                {
                    case "Left leg":
                    case "Right leg":
                        enemyLife -= randNum.Next(damage, Convert.ToInt32((damage * 1.1)));
                        break;
                    case "Left hand":
                    case "Right hand":
                        enemyLife -= randNum.Next(Convert.ToInt32((damage * 0.8)), Convert.ToInt32((damage * 1.2)));
                        break;
                    case "Torso":
                        enemyLife -= randNum.Next(Convert.ToInt32((damage * 0.5)), Convert.ToInt32((damage * 2)));
                        break;
                    case "Head":
                        enemyLife -= randNum.Next(0, Convert.ToInt32((damage * 3)));
                        break;

                    default:
                        enemyLife -= 0;
                        break;
                }
                Console.WriteLine("\n" + CurrentEnemy + " has " + enemyLife + " left!");
                if(enemyLife > 0){
                    Console.WriteLine("\n" + CurrentEnemy + " tries to hit You, but You dodged attack!");
                }
            }
            enemyLife = randNum.Next(20, 61);
            Console.WriteLine(enemyLife);
            CurrentEnemy = enemy[randNum.Next(0, 6)];

            while(enemyLife >= 0)
            {
                Console.WriteLine("\n" + CurrentEnemy + " is ready to fight. You attack first, choose where!\n");
                
                for (int i = 0; i < parts.Length; i++)
                {
                    Console.WriteLine(parts[i]);
                }

                string attack = Console.ReadLine();

                switch (attack)
                {
                    case "Left leg":
                    case "Right leg":
                        enemyLife -= randNum.Next(damage, Convert.ToInt32((damage * 1.1)));
                        break;
                    case "Left hand":
                    case "Right hand":
                        enemyLife -= randNum.Next(Convert.ToInt32((damage * 0.8)), Convert.ToInt32((damage * 1.2)));
                        break;
                    case "Torso":
                        enemyLife -= randNum.Next(Convert.ToInt32((damage * 0.5)), Convert.ToInt32((damage * 2)));
                        break;
                    case "Head":
                        enemyLife -= randNum.Next(0, Convert.ToInt32((damage * 3)));
                        break;

                    default:
                        enemyLife -= 0;
                        break;
                }
                Console.WriteLine("\n" + CurrentEnemy + " has " + enemyLife + " left!");
                if(enemyLife > 0){
                    Console.WriteLine("\n" + CurrentEnemy + " tries to hit You, but You dodged attack!");
                }

                Console.WriteLine("Then, after a really tough fights... a rock falling down the moutain crashes Your body and You die in pain.\nTHE END");
            }
       }
    }

    class Wizard
    {
        public string name;
        public string spell;
        public int mana;
        public float experience;

        public Wizard(string _name, string _spell)
        {
            name = _name;
            spell = _spell;
            mana = 3;
            experience = 0f;
        }

        public void CastSpell()
        {
            if(mana > 0){
                Console.WriteLine(name + " casts " + spell);
                mana--;
                experience += 2;
            } else {
                Console.WriteLine(name + " can't cast more spells!");
            }
        }

        public void DrinkManaPotion()
        {
            Console.WriteLine(name + " drinks mana potions and restores his mana!");
            mana = 3;
        }
    }
}
