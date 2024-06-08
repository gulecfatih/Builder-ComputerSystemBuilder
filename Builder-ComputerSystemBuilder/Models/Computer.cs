using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_ComputerSystemBuilder.Models
{
    public class Computer
    {
        // Bilgisayarın özelliklerini temsil eden özellikler.
        public string Processor { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string GraphicsCard { get; set; }
        public string PowerSupply { get; set; }

        // Bilgisayarın özelliklerini string olarak formatlayıp döndüren metot.
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Processor: {Processor}");
            sb.AppendLine($"RAM: {RAM}");
            sb.AppendLine($"Storage: {Storage}");
            sb.AppendLine($"Graphics Card: {GraphicsCard}");
            sb.AppendLine($"Power Supply: {PowerSupply}");
            return sb.ToString();
        }

    }
}
