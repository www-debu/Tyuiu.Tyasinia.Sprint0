namespace Tyuiu.TiasinIA.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static object AdditionArray(int[] nubers)
        {
            var total = 0;
            for (var i = 0; i < nubers.Length; i++)
            {
                total = total + nubers[i];
            }
            return total;
        }
        public static object SubstractionArray(int[] nubers)
        {
            var total = 0;
            var index = 0;

            while (index < nubers.Length)
            {
                total = total - nubers[index];
                index++;
            }
            return total;
        }
        public static object MultiplicationArray(int[] nubers)
        {
            var total = 1;
            int index = 0;
            do
            {
                total = total * nubers[index];
                index++;
            }
            while (index < nubers.Length);
            return total;
        }

    }
}
