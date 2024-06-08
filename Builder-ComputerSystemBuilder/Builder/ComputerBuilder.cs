using Builder_ComputerSystemBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_ComputerSystemBuilder.Builder
{
    public class ComputerBuilder
    {
        private Computer _computer;

        public ComputerBuilder()
        {
            // Yapıcı metod, bir Computer nesnesi oluşturur ve _computer değişkenine atar.
            _computer = new Computer();
        }

        // İşlemciyi ayarlamak için kullanılan metot.
        public ComputerBuilder SetProcessor(string processor)
        {
            _computer.Processor = processor;
            return this;
        }

        // RAM'i ayarlamak için kullanılan metot.
        public ComputerBuilder SetRAM(string ram)
        {
            _computer.RAM = ram;
            return this;
        }

        // Depolamayı ayarlamak için kullanılan metot.
        public ComputerBuilder SetStorage(string storage)
        {
            _computer.Storage = storage;
            return this;
        }

        // Ekran kartını ayarlamak için kullanılan metot.
        public ComputerBuilder SetGraphicsCard(string graphicsCard)
        {
            _computer.GraphicsCard = graphicsCard;
            return this;
        }

        // Güç kaynağını ayarlamak için kullanılan metot.
        public ComputerBuilder SetPowerSupply(string powerSupply)
        {
            _computer.PowerSupply = powerSupply;
            return this;
        }

        // Oluşturulan bilgisayar nesnesini döndüren metot.
        public Computer Build()
        {
            return _computer;
        }
    }

}
