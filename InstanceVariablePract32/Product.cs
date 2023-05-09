namespace InstanceVariablePract32
{
    internal class Product
    {
        public static string origin = "대한민국";
        public string name = "default";
        public int price = 0;

        public override string ToString()
        {
            return "이름: "+this.name+" / 가격: "+this.price;
        }
    }
}