using System;
using BuilderPattern.Components;
using BuilderPattern.Interfaces;

namespace BuilderPattern.Consultants
{
    public class Consultant
    {
        private IBuilder _builder;
        
        public IBuilder Builder
        {
            set => _builder = value;
        }

        public void BuildSuperMegaDuperComputer()
        {
            _builder
                .SetMotherCard(new MotherCard("Gigabyte X299X Aorus Xtreme Waterforce", Int32.MaxValue))
                .SetCpu(new Cpu("AMD Ryzen Threadripper 3990X", 5.1, 64))
                .SetRam(new Ram("HyperX DDR4-3600 131072MB PC4-28800", Int32.MaxValue))
                .SetStorageDevice(new StorageDevice("SSD Kingston DC450R 7.68TB", "SSD"))
                .SetVideoCard(new VideoCard("MSI PCI-Ex GeForce RTX 3090 GAMING X TRIO 24GB GDDR6X", 24));
        }

        public void BuildClassicComputer()
        {
            _builder
                .SetMotherCard(new MotherCard("Dell E93839 TE0423", 1))
                .SetCpu(new Cpu("Intel Celeron E3300", 2.4, 2))
                .SetRam(new Ram("TakeMS 1Gb DDR3 1333MHz 1024MB 1Rx8", 1))
                .SetStorageDevice(new StorageDevice("HDD SATA 250GB Seagate Barracuda 7200.12 7200rpm 8MB", "HDD"))
                .SetVideoCard(new VideoCard("Integrated", 0));
        }
    }
}