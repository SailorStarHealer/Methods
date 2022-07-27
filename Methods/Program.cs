public static class Program
{
    static int DiceRoll2(int numberOfRolls, int diceSides, int fixedBonus = 0)
    {
        var random = new Random();
        int sum = 0;


        //Repeat numberOfRolls times, rolling dice and adding the result to our sum.

        for (int index = 0; index < numberOfRolls; index++)
        {
            //Roll die with diceSides sides.
            int rollOfDice = random.Next(1, diceSides + 1);

            //Add the dice roll to the sum.
            sum += rollOfDice;

        }

        //Take the sum of that, add fixedBonus.
        int output = sum + fixedBonus;


        //Return the total result.
        return output;
    }



    static int DiceRoll(int numberOfRolls, int diceSides, int fixedBonus = 0)
    {
        int sum = 0;

        var random = new Random();

        for (int index = 0; index < numberOfRolls; index++)
        {
            int RollofDice = 0;
            RollofDice = random.Next(1, diceSides + 1);
            sum += RollofDice;



        }
        sum = sum + fixedBonus;
        return sum;

    }


    //Static int means that these integer values will exist until the end of
    //the program.
    // 'List' denotes the type of element. 'Strng' denotes the stuff inside the list.
    static void Fight(List<string> partyList, string monsterName, int monsterHP)
    {

        Console.WriteLine($"Monster {monsterName} appears!");
        int pindex = 0;
        int currentMonsterHP = monsterHP;
        int damage = 20;
        Console.WriteLine($"It's health points total {monsterHP}");


        do
        {
            var random = new Random();
            var greatSword = DiceRoll(2, 6, 0);
            var hero = partyList[pindex];
            Console.Write($"{hero} strikes the {monsterName} for {greatSword} damage. ");
            Console.WriteLine($"{monsterName} has {currentMonsterHP} HP left.");
            currentMonsterHP = currentMonsterHP - damage;
            pindex++;

            if (pindex >= partyList.Count)
            {
                var victim = partyList[random.Next(0, partyList.Count)];

                Console.WriteLine($"{monsterName} attacks {victim}!");
                int attack = random.Next(1, 21);
                var savingThrowDC = DiceRoll(1, 20, 0);
                if (attack >= savingThrowDC)
                {
                    partyList.Remove(victim);
                    Console.WriteLine($"Oh no, {victim} has fallen!");

                    pindex = 0;
                }


                else
                {
                    Console.WriteLine($"Yay, {victim} survived!");
                    pindex = 0;
                }
                if (partyList.Count == 0)
                {

                    break;
                }

                else
                {

                    pindex = 0;
                }


            }

        } while (currentMonsterHP > 0);
    }



    static void Main(string[] args)
    {


        /* var partyList = new List<string> { "Hideyoshi", "Yoko", "Tamhome", "Usagi" };

         Console.WriteLine("Main");

         Console.Write("Expected results between 2 and 12: ");
         for (int i = 0; i < 20; i++)
         {
             var sumDice = DiceRoll(2, 6, 0);
             Console.Write($"{sumDice} , ");
         }
         Console.WriteLine("");


         Console.Write("Expected results is 13: ");
         for (int i = 0; i < 20; i++)
         {
             var sumDice = DiceRoll(10, 1, 3);
             Console.Write($"{sumDice} , ");
         }
         Console.WriteLine("");


         Console.Write("Expected results between 105 and 140: ");
         for (int i = 0; i < 20; i++)
         {
             var sumDice = DiceRoll(5, 8, 100);
             Console.Write($"{sumDice} , ");
         }
         Console.WriteLine("");
        */

        var partyList = new List<string> { "Hideyoshi", "Yoko", "Tamhome", "Usagi" };

        Console.WriteLine($"A party of warriors ");
        foreach (var party in partyList)
        {
            Console.Write($"({party})");
        }
        Console.Write(" enter the dungeon.");
        Console.WriteLine($"");
      
        var sumDice = DiceRoll(2, 6, 0);

        Fight(partyList, "Orc", sumDice);
        var sumDice2 = DiceRoll(10, 1, 3);
        Fight(partyList, "Mage", sumDice2);

        var sumDice3 = DiceRoll(5, 8, 100);
        Fight(partyList, "Troll", sumDice3);

        if (partyList.Count == 0)
        {
            Console.WriteLine("Oh no! The entire party has been obliterated.");
            Console.WriteLine("ゲイムオバ");
        }
        else
        {
            Console.WriteLine($"A winner is you. Now go rest our heroes:");
            foreach (var item in partyList)
                Console.WriteLine(item);
        }
    }
}
/*Console.WriteLine($"A party of warriors ");
foreach (var party in partyList)
{
    Console.Write($"({party})");
}
Console.Write(" enter the dungeon.");
Console.WriteLine($"");
var sum = 0;
sum = DiceRoll(2, 8, 6);

Fight(partyList, "Orc", sum, 12);
var sum1 = 0;
sum1 = DiceRoll(9, 6, 0);
Fight(partyList, "Mage", sum, 20);

var sum2 = 0;
sum2 = DiceRoll(8, 10, 40);
Fight(partyList, "Troll", sum, 18);

if (partyList.Count == 0)
{
    Console.WriteLine("Oh no! The entire party has been obliterated.");
    Console.WriteLine("ゲイムオバ");
}
else
{
    Console.WriteLine($"A winner is you. Now go rest our heroes:");
    foreach (var item in partyList)
        Console.WriteLine(item);
}

}
}
*/
