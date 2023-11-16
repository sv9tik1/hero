using System;
//brief Род. класс с параметрами героя и методом Compareble, который сравнивает характеристики.
public class Hero : IComparable<Hero>
{
    public string Name { get; set; }
    public int Level { get; set; }

public Hero(string name, int level)
{
    Name = name;
    Level = level;
}

//brief выводит уровень героя.
public int CompareTo(Hero other)
{
return Level.CompareTo(other.Level);
}

//brief выводит атаку героя.
public void Attack()
{
Console.WriteLine($"{Name} наносит урон барашками!");
}
//brief защита героя 
public void Defend()
{
Console.WriteLine($"{Name} он сьел барашку!");
}

//brief повешения уровня.
public void LevelUp()
{
Level++;
}

//brief метод увеличивает значение переменной "Level" на значение "experience" разделенное на 100.
public void GainExperience(int experience)
{
Level += experience / 100;
}

//brief Выводит информацию героя.
public void DisplayInfo()
{
Console.WriteLine($"Имя героя: {Name}");
Console.WriteLine($"Уровень: {Level}");
}
}


class Program
{
static void Main(string[] args)

{
    //brief Отвечает за создания героя.

        Hero warrior = new Hero("Мага", 30);
        Hero mage = new Hero("Саид", 40);

        warrior.Attack();
        mage.Defend();
 
        warrior.LevelUp();
        mage.GainExperience(250);
        mage.DisplayInfo();

    //brief Метод сравнения героев по характеристикам.

        int result = warrior.CompareTo(mage);
        if (result > 0)
        {
             Console.WriteLine($"{warrior.Name} сильнее, чем {mage.Name}!");
        }
        else if (result < 0)
        {
             Console.WriteLine($"{mage.Name} слабее, чем {warrior.Name}!");
        }
        else 
        {
            Console.WriteLine($"{warrior.Name} и {mage.Name} одинаковы по силе!");
        }

}
}