namespace ClientApplication.Classes
{
    public class Sensor
    {
        private readonly long _id;
        private readonly string _name;
        private readonly double[] _data;
        private readonly string _type;
        public Sensor(long id, string name, double[] data, string type)
        {
            _id = id;
            _name = name;
            _data = data;
            _type = type;
        }
        public long GetId { get { return _id; } }
        public string GetName { get { return _name; } }
        public double[] GetData { get { return _data; } }
        public new string GetType { get { return _type; } }
    }
}
