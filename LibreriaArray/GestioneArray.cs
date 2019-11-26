using System;

namespace LibreriaArray
{
    public class GestioneArray
    {
        public static void LeggiArray(int[] array)
        {
            for (int x = 0; x < array.Length; x++)
            {
                Console.WriteLine($"Inserire il numero {x}");
                int a = int.Parse(Console.ReadLine());
                array[x] = a;
            }
        }
        public static void StampaArray(int[] array)
        {
            Console.Write("Il contenuto dell'array è: ");
            for (int x = 0; x < array.Length; x++)
            {
                Console.Write(array[x] + " ");
            }
            Console.WriteLine();
        }
        public static int[] CopiaArray(int[] array)
        {
            int[] array2 = new int[array.Length];
            for (int x = 0; x < array.Length; x++)
            {
                array2[x] = array[x];
            }
            return array2;
        }
        public static bool SonoUguali(int[] array, int[] array2)
        {
            if (array.Length != array2.Length)
                return false;
            bool risultato = true;
            for (int x = 0; x < array.Length; x++)
            {
                if (array[x] != array2[x])
                    risultato = false;
            }
            return risultato;
        }
        public static void RiempiArray(int[] array)
        {
            Random random = new Random();
            for (int x = 0; x < array.Length; x++)
            {
                array[x] = random.Next();
            }
        }
        public static int[] Unisci(int[] array, int[] array2)
        {
            int[] Merge = new int[array.Length + array2.Length];
            for (int i = 0; i < array.Length; i++)
            {
                Merge[i] = array[i];
            }
            for (int i = array.Length + 1; i < Merge.Length; i++)
            {
                Merge[i] = array2[i - array.Length];
            }
            return Merge;
        }
        public static int CercaMax(int[] array)
        {
            int max = int.MinValue;
            for (int x = 0; x < array.Length; x++)
            {
                if (array[x] > max)
                    max = array[x];
            }
            return max;
        }
        public static int CercaMin(int[] array)
        {
            int min = int.MaxValue;
            for (int x = 0; x < array.Length; x++)
            {
                if (array[x] < min)
                    min = array[x];
            }
            return min;
        }
        public static bool Crescente(int[] array)
        {
            bool risposta = true;
            for (int x = 1; x < array.Length; x++)
            {
                if (array[x] <= array[x - 1])
                    risposta = false;
            }
            return risposta;
        }
        public static bool Decrescente(int[] array)
        {
            bool risultato = true;
            for (int x = 1; x < array.Length; x++)
            {
                if (array[x] >= array[x - 1])
                    risultato = false;
            }
            return risultato;
        }
    }
}
