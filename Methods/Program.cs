public static class Program
{
    static int DiceRoll(int numberOfRolls, int diceSides, int fixedBonus = 0)
    {
        int sum = 0;

        var random = new Random();

        for (int index = 0; index <= numberOfRolls; index++)
        {
            int RollofDice = 0;
            RollofDice = random.Next(1, diceSides + 1);
            sum = RollofDice += fixedBonus;


        }

        return sum;

    }

    /* {
    var random = new Random();
    int orcHp = 6;
    int mageHp = 0;
    int trollHp = 40;

    for (int index = 0; index < 3; index++) {
        int d8 = random.Next(1, 9);
        orcHp += d8;
    }

    for (int index = 0; index < 10; index++)
    {
        int d8 = random.Next(1, 9);
        mageHp += d8;

    }

    for (int index = 0; index < 9; index++)
    {
        int d10 = random.Next(1, 11);
        trollHp += d10;

    }
    static int Battle(List<string> list)
    {


    return 5;
    }
    */


    //Static int means that these integer values will exist until the end of
    //the program.
    // 'List' denotes the type of element. 'Strng' denotes the stuff inside the list.
    static void Fight(List<string> partyList, string monsterName, int monsterHP, int savingThrowDC)
    {
        int pindex = 0;
        int currentMonsterHP = monsterHP;
        int damage = 20;


        do
        {
            var random = new Random();
            int attack1 = random.Next(1, 7);
            int attack2 = random.Next(1, 7);
            damage = attack1 + attack2;
            var hero = partyList[pindex];
            Console.Write($"{hero} strikes the {monsterName} for {damage} damage. ");
            Console.WriteLine($"{monsterName} has {currentMonsterHP} HP left.");
            pindex++;

            if (pindex >= partyList.Count)
            {
                var victim = partyList[random.Next(0, partyList.Count)];
                currentMonsterHP = currentMonsterHP - damage;
                Console.WriteLine($"{monsterName} attacks {victim}!");
                int attack = random.Next(1, 21);
                if (attack > savingThrowDC)
                {
                    partyList.Remove(victim);
                    Console.WriteLine($"Oh no, {victim} has fallen!");

                    pindex = 0;
                }

                else
                { pindex = 0; }
                pindex = 0;
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
        var partyList = new List<string> { "Hideyoshi", "Yoko", "Tamhome", "Usagi" };

        Console.WriteLine("Main");


        Console.WriteLine($"A party of warriors ");
        foreach (var party in partyList)
        {
            Console.Write($"({party})");
        }
        Console.Write(" enter the dungeon.");
        Console.WriteLine($"");
        Console.WriteLine($"An Orc appears!");
        var sum = 0;
        sum = DiceRoll(2, 8, 6);
        Console.WriteLine($"It's health points total {sum}");

        Fight(partyList, "Orc", sum, 12);

        Console.WriteLine($"A Mage appears!");
        var sum1 = 0;
        sum1 = DiceRoll(9, 6, 0);
        Console.WriteLine($"It's health points total {sum1}");
        Fight(partyList, "Mage", 40, 20);
        Console.WriteLine($"A Troll appears!");

        var sum2 = 0;
        sum2 = DiceRoll(8, 10, 40);
        Console.WriteLine($"It's health points total {sum2}");
        Fight(partyList, "Troll", 84, 18);

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


/*

Console.WriteLine($"A party of warriors ");
var partyList = new List<string> { "Hideyoshi", "Yoko", "Tamhome", "Usagi" };
foreach (var party in partyList)
{
    Console.Write($"({party})");
}
Console.Write(" enter the dungeon.");
Console.WriteLine($"");
Console.WriteLine($"An Orc appears!");

var random = new Random();
int monsterHP = 16;
for (int index = 0; index < 9; index++)
{
    int d8 = random.Next(random.Next(1, 9));
    monsterHP += d8;
}
Console.WriteLine($"It's health points total {monsterHP}");


var pindex = partyList.Count;
pindex = 0;

do
{
    var hero = partyList[pindex];
    int d4 = random.Next(1, 5);
    int damage = d4;
    monsterHP -= damage;
    Console.Write($"{hero} strikes the basilisk for {damage} damage. ");
    Console.WriteLine($"Basilisk has {monsterHP} HP left.");
    pindex++;
    if (pindex >= partyList.Count)
    {
        var victim = partyList[random.Next(0, partyList.Count)];

        Console.WriteLine($"Basilisk casts Petrifying Gaze on {victim}!");
        int attack = random.Next(1, 21);
        if (attack + 5 > 12)
        {
            partyList.Remove(victim);
            Console.WriteLine($"Oh no, {victim} turned to stone!");

        }
        else
        { pindex = 0; }
        pindex = 0;
        if (partyList.Count == 0)
        {

            break;
        }

        else
        {

            pindex = 0;
        }

    }
} while (monsterHP > 0);
if (partyList.Count == 0)
{
    Console.WriteLine("Oh no! The entire party has been obliterated.");
    Console.WriteLine("ゲイムオバ");
}
else
{
    Console.WriteLine("Conglaturation! The monster is dead. You win!");
}
*/