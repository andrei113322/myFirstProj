// See https://aka.ms/new-console-template for more information
using noyeProj;

Animal[] animals =
{
    new Animal("asxa", 11, true, 1400),
    new Bird("asa", 12, false, 800, 40, 23),
    new Mammal("scs", 13, true, 2345, 134, 8),
    new Reptile("sdcsd", 14, true, 2346, 39)
};

foreach (var item in animals)
{
    Console.WriteLine(item.ToString() + "\n");
}

Reptile[] reptiles =
{
    new Reptile("ascas", 34, true, 45, 90),
    new Crocodile("dscs", 34, true, 89, 12, true),
    new Snake("sdc", 56, false, 23, 89, true),
    new Python("sdcsd", 12, true, 67, 34, false, 9909)
};

foreach (var item in reptiles)
{
    Console.WriteLine(item.ToString() + "\n");
}

Mammal[] mammals =
{
    new Mammal("Sadad", 34, true, 5678, 67, 89),
    new Cow("vddv", 34, true, 234, 67, 2, 45),
    new Hipo("dvdv", 34, false, 234, 67, 4, 89),
    new Cow("dvdv", 234, true, 678, 34, 2, 67)
};

foreach (var item in mammals)
{
    Console.WriteLine(item.ToString() + "\n");
}

static int caloriesSum(Animal[] aniArr)
{
    int sum = 0;
    foreach (var item in aniArr)
    {
        sum += item.eat();
    }
    return sum;
}

static int sumMammal(Animal[] aniArr)
{
    int sum = 0;

    foreach (var item in aniArr)
    {
        if (item is Mammal)
        {
            sum++;
        }
    }
    return sum;
}

static void DanceClub(Animal[] aniArr)
{
    foreach (var item in aniArr)
    {
        if (item is Bird)
        {
            ((Bird)item).Dance();
        }
        else if (item is Snake)
        {
            ((Snake)item).Dance();
        }
    }
}

static string fatestHipo(Animal[] aniArr)
{
    string name = "";
    int num = 0;
    foreach (var item in aniArr)
    {
        if (item is Hipo)
        {
            if (num < ((Hipo)item).getFatProcentale())
            {
                num = ((Hipo)item).getFatProcentale();
                name = ((Hipo)item).getName();
            }
        }
    }
    return name;
}