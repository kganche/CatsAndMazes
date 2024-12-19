namespace Cats;

public class CatAncestryTree(Cat rootCat)
{
    private Cat root = rootCat;

    public bool IsPurebred()
    {
        return root.IsPurebred();
    }
}