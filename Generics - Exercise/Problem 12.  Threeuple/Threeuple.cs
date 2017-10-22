
public class Threeuple<T, U, V>
{
    public Threeuple(T firstItem, U secondItem, V thirdItem)
    {
        this.FirstItem = firstItem;
        this.SecondItem = secondItem;
        this.ThirdItem = thirdItem;
    }

    public T FirstItem { get; private set; }

    public U SecondItem { get; private set; }

    public V ThirdItem { get; private set; }

    public override string ToString()
    {
        return $"{this.FirstItem.ToString()} -> {this.SecondItem.ToString()} -> {this.ThirdItem.ToString()}";
    }
}

