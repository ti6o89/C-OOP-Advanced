using System;
using System.Collections;
using System.Collections.Generic;

public class ListyIterator<T> : IEnumerable<T>
{
    private IList<T> myList;
    private int currentIndex;

    public ListyIterator(IEnumerable<T> items)
    {
        this.myList = new List<T>(items);
    }

    public bool Move()
    {
        if (this.currentIndex + 1 < myList.Count)
        {
            this.currentIndex++;
            return true;
        }
        return false;
    }

    public bool HasNext()
    {
        if (this.currentIndex + 1 < myList.Count)
        {
            return true;
        }
        return false;        
    }

    public void Print()
    {
        if (this.myList.Count <= 0)
        {
            throw new ArgumentException("Invalid Operation!");
        }
        Console.WriteLine(this.myList[this.currentIndex]);
    }

    public void PrintAll()
    {
        if (this.myList.Count <= 0)
        {
            throw new ArgumentException("Invalid Operation!");
        }

        Console.WriteLine(string.Join(" ", myList));
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.myList.Count; i++)
        {
            yield return this.myList[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

