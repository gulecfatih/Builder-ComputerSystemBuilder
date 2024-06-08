using Builder_ComputerSystemBuilder.Builder;
using Builder_ComputerSystemBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_ComputerSystemBuilder
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ComputerBuilder kullanarak bir bilgisayar sistemi oluşturalım
            ComputerBuilder builder = new ComputerBuilder();
            Computer myComputer = builder.SetProcessor("Intel i7")
                                         .SetRAM("16GB")
                                         .SetStorage("1TB SSD")
                                         .SetGraphicsCard("NVIDIA RTX 3080")
                                         .SetPowerSupply("750W")
                                         .Build();

            Console.WriteLine(myComputer);

        }
    }
}
