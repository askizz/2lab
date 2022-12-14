namespace ConsoleApplication1
{

    using System;
    using System.Collections.Generic;

    class Device
    {
        public string Model { get; set; }
        public string Mhz { get; set; }
        public string Ram { get; set; }
        public string Hdd { get; set; }
        public string Weight { get; set; }
        public string com { get; set; }

        public Device()
        {
            Model = "Undefined";
            Mhz = "Undefined";
            Ram = "Undefined";
            Hdd = "Undefined";
            Weight = "Undefined";
        }

        public Device(string m, string mh, string r, string h, string w)
        {
            Model = m;
            Mhz = mh;
            Ram = r;
            Hdd = h;
            Weight = w;
        }

        public Device(Device obj)
        {
            Model = obj.Model;
            Mhz = obj.Mhz;
            Ram = obj.Ram;
            Hdd = obj.Hdd;
            Weight = obj.Weight;
        }

        public Device Clon()
        {
            return new Device(this);
        }

        public string Info
        {
            get
            {
                return $"Model: {Model}\n" +
                       $"CPU Frequency: {Mhz}\n" +
                       $"RAM Capacity: {Ram}\n" +
                       $"HDD Capacity: {Hdd}\n" +
                       $"Weight: {Weight}\n";
            }
        }



    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Device> devices = new List<Device>()
            {
                new Device("ASUS X415JF", "1", "2", "3", "4"),
                new Device("Lenovo V15-IGL", "1", "2", "2", "4"),
                new Device("ASUS X509FA", "1", "2", "3", "4"),
                new Device("Asus ZenBook R565EA", "1", "4", "3", "4"),
                new Device("Huawei MateBook D 14", "2", "2", "3", "4.5")

            };

            foreach (var device in devices)
            {
                Console.WriteLine(device.Info);
            }

            Console.WriteLine
            ("Del objects of 1 and 3 indexes from the list");

            devices.RemoveAt(1);
            devices.RemoveAt(3);

            foreach (var device in devices)
            {
                Console.WriteLine(device.Info);
            }
        }
    }
}