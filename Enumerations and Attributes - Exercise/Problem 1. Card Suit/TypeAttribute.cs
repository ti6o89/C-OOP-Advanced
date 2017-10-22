using System;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum)]
public class TypeAttribute : Attribute
{
    private string type;
    private string category;
    private string description;

    public TypeAttribute(string type, string category, string description)
    {
        this.Type = type;
        this.Category = category;
        this.Desctription = description;
    }

    public string Type { get; private set; }

    public string Category { get; private set; }

    public string Desctription { get; private set; }

    public override string ToString()
    {
        return $"Type = {this.Type}, Description = {this.Desctription}";
    }
}
