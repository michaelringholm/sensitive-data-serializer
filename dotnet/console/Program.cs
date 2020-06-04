using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var partlySensitiveObject  = new MyPartlySensitiveObject();
            partlySensitiveObject.CPRNumber = new SensitiveString("100200300400");
            partlySensitiveObject.Gender = "Male";
            partlySensitiveObject.FullName = "John Doe";
            partlySensitiveObject.Income = new SensitiveString("100000");
            var serializer = new SensitiveDataSerializer();
            var json = serializer.Serialize(partlySensitiveObject);
            Console.WriteLine(json);
        }
    }
}
