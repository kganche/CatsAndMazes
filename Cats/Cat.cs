namespace Cats;

public class Cat(string name, string breed, Cat mother = null, Cat father = null)
{
    public string Name { get; set; } = name;

    public string Breed { get; set; } = breed;

    public Cat? Mother { get; set; } = mother;

    public Cat? Father { get; set; } = father;

    public bool IsPurebred()
    {
        return IsPurebred(this, 3);
    }

    private static bool IsPurebred(Cat? cat, int level)
    {
        if (cat is null || level == 0)
        {
            return true;
        }

        if (cat.Mother is not null && cat.Mother.Breed != cat.Breed)
        {
            return false;
        }

        if (cat.Father is not null && cat.Father.Breed != cat.Breed)
        {
            return false;
        }

        return IsPurebred(cat.Mother, level - 1) && IsPurebred(cat.Father, level - 1);
    }
}