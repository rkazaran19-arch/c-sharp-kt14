using System.Collections;

namespace App.Topics.Collections.T1_Collections;

public static class CollectionsTasks
{
    public static ArrayList FilterUniqueStringsNonGeneric(IEnumerable source)
    {
        ArrayList result = new ArrayList();
        HashSet<string> uniqueStrings = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        foreach (var item in source)
        {
            if (item is not string str)
                continue;
            if (string.IsNullOrWhiteSpace(str))
                continue;

            str = str.Trim();

            if (uniqueStrings.Add(str))
            {
                result.Add(str); 
            }
        }

        return result;
    }

    public static ArrayList FilterUniqueStringsGeneric(IEnumerable<string> source)
    {
        ArrayList result = new ArrayList();
        HashSet<string> uniqueStrings = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        foreach (var item in source)
        {
            if (string.IsNullOrWhiteSpace(item))
                continue;

           var str = item.Trim();

            if (uniqueStrings.Add(str))
            {
                result.Add(str);
            }
        }

        return result;
    }
}


