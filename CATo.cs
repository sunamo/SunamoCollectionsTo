namespace SunamoCollectionsTo;

public class CATo
{
    public static List<T> ToList<T>(params T[] t)
    {
        return t.ToList();
    }

    public static T[] ToArray<T>(params T[] t)
    {
        return t;
    }
}
