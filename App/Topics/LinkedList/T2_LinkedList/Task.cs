namespace App.Topics.LinkedList.T2_LinkedList;

using System.Collections.Generic;

public static class LinkedListTasks
{
    public static LinkedList<int> RemoveDuplicates(LinkedList<int> list)
    {
        if (list == null)
            throw new ArgumentNullException(nameof(list));

        LinkedList<int> result = new LinkedList<int>();
        HashSet<int> uniqueInts = new HashSet<int>();

        foreach (var item in list)
        {
            if (uniqueInts.Add(item))
            {
                result.AddLast(item);
            }
        }

        return result;
    }
}
