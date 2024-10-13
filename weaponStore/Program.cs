namespace weaponStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pistols pistols = new Pistols();
            
            Shotguns shotguns = new Shotguns();
            Smg smg = new Smg();
            Rifles rifles = new Rifles();
            MachineGuns machineGuns = new MachineGuns();
            
            
            Console.WriteLine("Start the game");
            Console.WriteLine("----------");
            Console.WriteLine(" Weapon category");
            
            Category category = new Category();

            for (int i = 0; i < category.Name.Length; i++)
            {
                Console.WriteLine($"{i+1}) {category.Name[i]}");
            }
            Console.Write($"Choose category: ");
            string selectedCategory = Console.ReadLine();
          

            Console.WriteLine("-----------");

            Console.WriteLine($"you chose - {selectedCategory}");
            Console.WriteLine("-----------");

            switch (selectedCategory)
            {
                case "PISTOLS":

                    for (int i = 0; i < pistols.Name.Length; i++)
                    {
                        Console.WriteLine(pistols.Name[i]);
                        
                    }
                    break;
                case "SHOTGUNS":

                    for (int i = 0; i < shotguns.Name.Length; i++)
                    {
                        Console.WriteLine(shotguns.Name[i]);
                    }
                    break;
                case "SMG":

                    for (int i = 0; i < smg.Name.Length; i++)
                    {
                        Console.WriteLine(smg.Name[i]);
                    }
                    break;
                case "RIFLES":

                    for (int i = 0; i < rifles.Name.Length; i++)
                    {
                        Console.WriteLine(rifles.Name[i]);
                    }
                    break;
                case "MACHINE GUNS":

                    for (int i = 0; i < machineGuns.Name.Length; i++)
                    {
                        Console.WriteLine(machineGuns.Name[i]);
                    }
                    break;

                default:
                    Console.WriteLine("Category not found.");
                    break;
            }


            Console.WriteLine("-----------");
            Console.Write("Choose model: ");
            string weponsModel = Console.ReadLine();

            Console.WriteLine($"You bought {weponsModel}  model ");







        }
    }
}
