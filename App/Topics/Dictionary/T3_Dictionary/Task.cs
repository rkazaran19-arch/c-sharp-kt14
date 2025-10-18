using System.Collections;
using System.Collections.Generic;


namespace App.Topics.Dictionary.T3_Dictionary;

public static class DictionaryTasks
{
    public static List<KeyValuePair<string, int>> TopNWords(string text, int n)
    {
        if (text == null)
            return [];
        if (n <= 0)
            return [];

        var delitely = GetDelitely(text);
        var resultDels = text.Split(delitely);

       return resultDels
            .Where(str => !string.IsNullOrWhiteSpace(str))
            .Select(str => str.ToLower())
            .GroupBy(resultDel => resultDel, StringComparer.OrdinalIgnoreCase)
            .Select(group => new KeyValuePair<string, int>(group.Key, group.Count()))
            .OrderByDescending(kv => kv.Value)
            .Take(n)
            .ToList();
    }

    private static char[] GetDelitely(string text)
    {
        var result = new List<char>();

        foreach (var item in text)
        {
            if (!char.IsLetterOrDigit(item))
            {
                result.Add(item);
            }
        }

        return result.ToArray();
    }
}