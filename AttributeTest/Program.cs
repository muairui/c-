using System;

namespace AttributeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new People()
            {
                Name = "qweasdzxcasdqweasdzxc",
                Description = "description"
            };
            try
            {
                new ValidationModel().Validate(people);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
