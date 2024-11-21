using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    internal class Algorithms
    {
        public static void MergeSort(int[] array, int left, int right, Action<int[], string> displayCallback)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                displayCallback(array[left..(right + 1)], "División: " + left + " - " + right);

                MergeSort(array, left, middle, displayCallback);
                MergeSort(array, middle + 1, right, displayCallback);
                Merge(array, left, middle, right, displayCallback);
            }

        }

        private static void Merge(int[] array, int left, int middle, int right, Action<int[], string> displayCallback)
        {
            // Creamos copias de las mitades izquierda y derecha del arreglo
            int[] leftArray = array[left..(middle + 1)];
            int[] rightArray = array[(middle + 1)..(right + 1)];
            // Inicializamos índices para recorrer cada arreglo y el arreglo original:
            int i = 0, j = 0, k = left;
            // Mientras haya elementos por comparar en ambos arreglos:
            while (i < leftArray.Length && j < rightArray.Length)
                // Copiamos el elemento más pequeño al arreglo original:
                array[k++] = leftArray[i] <= rightArray[j] ? leftArray[i++] : rightArray[j++];
            //           // Copiamos los elementos restantes del arreglo izquierdo (si los hay):
            while (i < leftArray.Length)
                array[k++] = leftArray[i++];
            while (j < rightArray.Length)
                array[k++] = rightArray[j++];

            displayCallback(array, "Merge paso completado");
        }

        public static void DirectMerge(int[] array, Action<int[], string> displayCallback)
        {
            int n = array.Length;// Obtener el tamaño del arreglo
            int[] temp = new int[n]; // Crear un arreglo temporal del mismo tamaño
            // Iterar sobre diferentes tamaños de subarreglos (width)
            for (int width = 1; width < n; width *= 2)
            {
                displayCallback(array.ToArray(), "División con width = " + width);
                // Iterar sobre los subarreglos de tamaño 2*width
                for (int i = 0; i < n; i += 2 * width)
                {
                    int left = i; // Índice inicial del subarreglo izquierdo
                    int middle = Math.Min(i + width, n); // Índice del último elemento del subarreglo izquierdo
                    int right = Math.Min(i + 2 * width, n);// Índice del último elemento del subarreglo derecho

                    // Fusionar los subarreglos izquierdo y derecho en el arreglo temporal
                    int l = left, r = middle, k = left;

                    //se ejecuta mientras ambos sub - arreglos tienen elementos por mezclar.
                    while (l < middle && r < right)
                        temp[k++] = array[l] <= array[r] ? array[l++] : array[r++];
                    // Copiar los elementos restantes de los subarreglos (si los hay
                    while (l < middle)
                        temp[k++] = array[l++];
                    while (r < right)
                        temp[k++] = array[r++];
                }
                // Copiar el arreglo temporal de vuelta al arreglo original
                Array.Copy(temp, array, n);
                displayCallback(array.ToArray(), "Mezcla después de width = " + width);
            }
        }

        public static void NaturalMerge(int[] array, Action<int[], string> displayCallback)
        {

            bool ordenado = false;
            int[] temp = new int[array.Length];
            //El ciclo while se ejecuta mientras ordenado sea false.
            while (!ordenado)
            {
                ordenado = true;
                int i = 0;
                // Mostrar el arreglo antes de iniciar el ciclo de mezcla
                displayCallback(array, "División en sub-secuencias");

                while (i < array.Length)
                {
                    int start = i;

                    // Encuentra el final de la primera secuencia ordenada
                    while (i < array.Length - 1 && array[i] <= array[i + 1])
                        i++;
                    i++;

                    int j = i;

                    // Encuentra el final de la segunda secuencia ordenada
                    while (i < array.Length - 1 && array[i] <= array[i + 1])
                        i++;
                    i++;

                    // Mezcla las sub-secuencias en el arreglo temporal
                    if (j < array.Length)
                    {
                        MergeNatural(array, start, j, Math.Min(i, array.Length), temp);
                        ordenado = false;
                    }
                }

                // Copia el arreglo temporal de vuelta al arreglo original
                Array.Copy(temp, 0, array, 0, array.Length);

                // Muestra el estado del arreglo después de cada ciclo de mezcla
                displayCallback(array, "Mezcla completa");
            }
        }

        // Método MergeNatural sin el callback interno
        private static void MergeNatural(int[] array, int left, int middle, int right, int[] temp)
        {
            int i = left, j = middle, k = left;
            while (i < middle && j < right)
                temp[k++] = array[i] <= array[j] ? array[i++] : array[j++];

            while (i < middle) temp[k++] = array[i++];
            while (j < right) temp[k++] = array[j++];
        }
    }
}
