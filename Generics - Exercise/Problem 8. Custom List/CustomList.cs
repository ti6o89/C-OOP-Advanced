using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class CustomList<T> : ICustomList<T>, IEnumerable<T>
    where T : IComparable<T>
{
    private IList<T> elements;

    public CustomList() : this(Enumerable.Empty<T>())
    {

    }

    public CustomList(IEnumerable<T> colection)
    {
        this.elements = new List<T>(colection);
    }

    public IList<T> Elements
    {
        get { return this.elements; }
    }

    public void Add(T element)
    {
        this.elements.Add(element);
    }

    public bool Contains(T element)
    {
        return this.elements.Contains(element);
    }

    public int CountGreaterThan(T element)
    {
        return elements.Count(e => e.CompareTo(element) > 0);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return this.elements.GetEnumerator();
    }

    public T Max()
    {
        return this.elements.Max();
    }

    public T Min()
    {
        return this.elements.Min();
    }

    public T Remove(int index)
    {
        T temp = this.elements[index];
        this.elements.RemoveAt(index);
        return temp;    
    }

    public void Swap(int index1, int index2)
    {
        T temp = elements[index1];
        elements[index1] = elements[index2];
        elements[index2] = temp;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
