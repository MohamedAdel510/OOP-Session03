namespace FirstProject
{
    internal class Program
    {
        public static _3DPoint CreateObj() 
        {
            int X, Y, Z;
            Console.WriteLine("Point : ");
            do
            {
                Console.Write("X: ");
            } while (!int.TryParse(Console.ReadLine(), out X));

            Console.Write("Y: ");
           
            Y = int.Parse(Console.ReadLine());
       
            Console.Write("Z: ");
            Z = Convert.ToInt32(Console.ReadLine());

            return new _3DPoint(X, Y, Z);
        }
        static void Main(string[] args)
        {
            _3DPoint P1 = CreateObj();
            _3DPoint P2 = CreateObj();

            if (P1 == P2)
            {
                Console.WriteLine("Same Points");
            }
            else
            {
                Console.WriteLine("Different");
            }

            _3DPoint[] _3DPoints =
            {
                new _3DPoint(10, 10, 10),
                new _3DPoint (1, 3, 5),
                new _3DPoint(12, 2, 3),
                new _3DPoint(8, 9, 10)
            };
            Array.Sort( _3DPoints, new _3DPointCompare());

            foreach ( _3DPoint point in _3DPoints)
            {
                Console.WriteLine (point);
            }
        }
    }
}
