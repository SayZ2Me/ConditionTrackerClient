namespace ClientApplication.Classes
{
    public class Device
    {
        public static List<Device> devices = new List<Device>();
        public List<Sensor> sensors = new List<Sensor>();
        public Sensor? timeSpan;

        private readonly long _id;
        private readonly string _name;
        private readonly string _ipv4_adress;
        private readonly string _real_adress;
        private readonly string _description;
        private readonly string _manufacturer;
        public Device(long id, string name, string ipv4_adress, string real_adress, string description, string manufacturer)
        {
            _id = id;
            _name = name;
            _ipv4_adress = ipv4_adress;
            _real_adress = real_adress;
            _description = description;
            _manufacturer = manufacturer;
        }
        public long Id { get { return _id; } }
        public string Name { get { return _name; } }
        public string IPv4_adress { get { return _ipv4_adress; } }
        public string Real_adress { get { return _real_adress; } }
        public string Description { get { return _description; } }
        public string Manufacturer { get { return _manufacturer; } }
    }
}
