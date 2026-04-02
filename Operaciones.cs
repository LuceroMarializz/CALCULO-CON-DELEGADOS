using System;  

namespace CALCULO_CON_DELEGADO
{
    public class PRESENTE_CLASE
    {
        public static int SUMAR(int A, int B)
        {
            return A + B;
        }

        public static int RESTAR(int A, int B)
        {
            return A - B;
        }

        public static int MULTIPLICAR(int A, int B)
        {
            return A * B;
        }

        public static int DIVIDIR(int A, int B)
        {
            if (B == 0)
            {
                Console.WriteLine("NO SE PUEDE DIVIDIR ENTRE CERO, LAMENTABLEMENTE");
                return 0; 
            }
            else
            {
                return A / B;
            }
        }
    }
}