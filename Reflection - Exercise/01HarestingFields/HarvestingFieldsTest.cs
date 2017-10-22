namespace _01HarestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    class HarvestingFieldsTest
    {
        static void Main(string[] args)
        {
            string command;
            while ((command = Console.ReadLine()) != "HARVEST")
            {
                Type harvestingFields = typeof(HarvestingFields);
                switch (command)
                {
                    case "protected":
                        FieldInfo[] protectedFields = harvestingFields.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
                        foreach (FieldInfo field in protectedFields.Where(f => f.IsFamily))
                        {
                            Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                        }
                        break;
                    case "private":
                        FieldInfo[] privateFields = harvestingFields.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
                        foreach (FieldInfo field in privateFields.Where(f => f.IsPrivate))
                        {
                            Console.WriteLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}");
                        }
                        break;
                    case "public":
                        FieldInfo[] publicFields = harvestingFields.GetFields(BindingFlags.Instance | BindingFlags.Public);
                        foreach (FieldInfo field in publicFields.Where(f => f.IsPublic))
                        {
                            Console.WriteLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}");
                        }
                        break;
                    case "all":
                        FieldInfo[] allFields = harvestingFields.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                        foreach (FieldInfo field in allFields)
                        {
                            if (field.IsFamily)
                            {
                                Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                            }
                            else
                            {
                                Console.WriteLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}");
                            }
                            
                        }
                        break;
                }
            }
        }
    }
}
