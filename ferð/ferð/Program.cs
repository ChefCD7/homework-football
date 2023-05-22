using System;
using System.Collections.Generic;

class Program
{
    private int currentLevel;
    private int playerHealth;
    private int enemyHealth;
    private bool gameOver;
    private int score;
    private Random random;
    private Dictionary<string, int> weapons;
    private List<string> enemies;
    private Player player;

    static void Main()
    {
        Program game = new Program();
        game.Run();
    }

    public Program()
    {
        currentLevel = 1;
        playerHealth = 100;
        enemyHealth = 0;
        gameOver = false;
        score = 0;
        random = new Random();
        weapons = new Dictionary<string, int>
        {
            { "Sword", 30 },
            { "Axe", 35 },
            { "Bow", 25 },
            { "War hammer", 45 },
            { "Scythe", 40 }
        };
        enemies = new List<string>
        {
            "Goblin",
            "Skeleton",
            "Orc",
            "Wyvern"
        };
        player = new Player();
    }

    public void Run()
    {
        Console.WriteLine("Welcome to The Land of the Litch");
        Console.WriteLine("Collect weapons, fight enemies, and reach the final level.");

        while (!gameOver)
        {
            Console.WriteLine();
            Console.WriteLine("Level: " + currentLevel);
            Console.WriteLine("Player Health: " + playerHealth);
            Console.WriteLine("Score: " + score);
            Console.WriteLine();

            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Look around");
            Console.WriteLine("2. Quit game");

            if (random.Next(1, 101) <= 50)
            {
                Console.WriteLine("3. Fully heal yourself");
            }

            Console.Write("Enter your choice: ");
            string? choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    LookAround();
                    break;
                case "2":
                    gameOver = true;
                    Console.WriteLine("Game over. Thanks for playing!");
                    Console.WriteLine("Final score: " + score);
                    break;
                case "3":
                    if (random.Next(1, 101) <= 100)
                    {
                        HealPlayer();
                        Console.WriteLine("You fully healed yourself!");
                    }
                    else
                    {
                        Console.WriteLine("You attempted to heal yourself, but it failed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void LookAround()
    {
        Console.WriteLine("You look around...");

        if (currentLevel == 10)
        {
            Console.WriteLine("You encountered the final boss: Litch");
            enemyHealth = random.Next(100, 125);

            while (playerHealth > 0 && enemyHealth > 0)
            {
                Console.WriteLine("Choose your action:");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");

                Console.Write("Enter your choice: ");
                string? choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "1")
                {
                    int playerDamage = player.Attack();
                    int enemyDamage = random.Next(10, 17);

                    enemyHealth -= playerDamage;
                    playerHealth -= enemyDamage;

                    Console.WriteLine("You attacked the boss and dealt " + playerDamage + " damage.");
                    Console.WriteLine("The boss attacked you and dealt " + enemyDamage + " damage.");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("You chose to defend. No damage taken this turn.");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

                Console.WriteLine();

                if (playerHealth <= 0)
                {
                    Console.WriteLine("You were defeated by the boss. Game over!");
                    gameOver = true;
                    Console.WriteLine("Final score: " + score);
                    break;
                }
                else if (enemyHealth <= 0)
                {
                    Console.WriteLine("Congratulations! You defeated the boss!");
                    score += 100;
                    gameOver = true;
                    Console.WriteLine("Final score: " + score);
                    break;
                }
            }
        }
        else
        {
            if (random.Next(1, 101) <= 60)
            {
                string enemy = GetRandomEnemy();
                Console.WriteLine("You encountered an enemy: " + enemy);
                enemyHealth = random.Next(65, 95);

                while (playerHealth > 0 && enemyHealth > 0)
                {
                    Console.WriteLine("Choose your action:");
                    Console.WriteLine("1. Attack");
                    Console.WriteLine("2. Defend");

                    Console.Write("Enter your choice: ");
                    string? choice = Console.ReadLine();
                    Console.WriteLine();

                    if (choice == "1")
                    {
                        int playerDamage = player.Attack();
                        int enemyDamage = random.Next(8, 13);

                        enemyHealth -= playerDamage;
                        playerHealth -= enemyDamage;

                        Console.WriteLine("You attacked the enemy and dealt " + playerDamage + " damage.");
                        Console.WriteLine("The enemy attacked you and dealt " + enemyDamage + " damage.");
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("You chose to defend. No damage taken this turn.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                    }

                    Console.WriteLine();

                    if (playerHealth <= 0)
                    {
                        Console.WriteLine("You were defeated by the enemy. Game over!");
                        gameOver = true;
                        Console.WriteLine("Final score: " + score);
                        break;
                    }
                    else if (enemyHealth <= 0)
                    {
                        Console.WriteLine("Congratulations! You defeated the enemy!");
                        score += 30;
                        break;
                    }
                }
            }
            else if (random.Next(1, 101) <= 40)
            {
                Console.WriteLine("You found an item!");

                if (random.Next(1, 101) <= 80)
                {
                    OpenChest();
                }
                else
                {
                    Console.WriteLine("It's a regular item. Nothing special.");
                    score += 10;
                }
            }
            else
            {
                Console.WriteLine("You found nothing of interest. Keep exploring!");
            }

            if (!gameOver)
            {
                Console.WriteLine("You can now proceed to the next level.");
                currentLevel++;
                score += 10;
            }
        }
    }

    private void HealPlayer()
    {
        playerHealth = 100;
    }

    private void OpenChest()
    {
        Console.WriteLine("You found a chest!");

        List<string> weaponNames = new List<string>(weapons.Keys);
        int index = random.Next(0, weaponNames.Count);
        string weaponName = weaponNames[index];
        int weaponDamage = weapons[weaponName];

        Console.WriteLine(weaponName + " (Damage: " + weaponDamage + ")");

        Console.WriteLine("Do you want to equip the weapon? (Y/N)");
        string? choice = Console.ReadLine();
        Console.WriteLine();

        if (choice?.ToUpper() == "Y")
        {
            player.EquipWeapon(weaponName, weaponDamage);
            Console.WriteLine("You equipped the weapon. Let's continue the adventure!");
            score += 20;
        }
        else
        {
            Console.WriteLine("You chose not to equip the weapon.");
        }
    }

    private string GetRandomEnemy()
    {
        int index = random.Next(0, enemies.Count);
        return enemies[index];
    }
}

class Player
{
    private string weapon;
    private int weaponDamage;

    public Player()
    {
        weapon = "Fists";
        weaponDamage = 15;
    }

    public void EquipWeapon(string weaponName, int damage)
    {
        weapon = weaponName;
        weaponDamage = damage;
    }

    public int Attack()
    {
        return weaponDamage;
    }
}
