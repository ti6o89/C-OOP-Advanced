
using System.Collections;
using System.Collections.Generic;

public class Box<T>
{

    public Box(T data)
    {
        this.Data = data;
    }

    public T Data { get; private set; }

    public override string ToString()
    {
        return $"{this.Data.GetType().FullName}: {this.Data}";
    }
}

