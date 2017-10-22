using System.Collections;
using System.Collections.Generic;

public class Lake : IEnumerable<int>
{
    private IList<int> stonesNumbers;

    public Lake(IEnumerable<int> stonesNumbers)
    {
        this.stonesNumbers = new List<int>(stonesNumbers);
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < this.stonesNumbers.Count; i+= 2)
        {
            yield return this.stonesNumbers[i];
        }

        int lastOddIndex = this.stonesNumbers.Count - 1;
        if (lastOddIndex % 2 == 0)
        {
            lastOddIndex--;
        }

        for (int i = lastOddIndex; i > 0; i-= 2)
        {
            yield return this.stonesNumbers[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
