namespace CALCULO_CON_DELEGADO
{
    class Program
    {
        // DELEGADO
        public delegate int OperationMatematica(int A, int B);

        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA CON DELEGADOS");

            Console.Write("INGRESE EL PRIMER NÚMERO: ");
            int N1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("INGRESE EL SEGUNDO NÚMERO: ");
            int N2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSELECCIONE UNA OPERACIÓN:");
            Console.WriteLine("1. SUMAR");
            Console.WriteLine("2. RESTAR");
            Console.WriteLine("3. MULTIPLICAR");
            Console.WriteLine("4. DIVIDIR");

            Console.Write("SELECCION: ");
            int SELECCION = Convert.ToInt32(Console.ReadLine());

            OperationMatematica[] Operaciones = { PRESENTE_CLASE.SUMAR, PRESENTE_CLASE.RESTAR, PRESENTE_CLASE.MULTIPLICAR, PRESENTE_CLASE.DIVIDIR };

            // EJECUTO MI DELEGADO
            int PRODUCTO = Operaciones[SELECCION - 1](N1, N2);

            Console.WriteLine($"\nPRODUCTO: {PRODUCTO}");

            Console.ReadKey();
        }
    }
}