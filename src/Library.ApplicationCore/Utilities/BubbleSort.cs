using System;

namespace Library.ApplicationCore.Utilities
{
    /// <summary>
    /// A utility class that implements the bubble sort algorithm for sorting arrays.
    /// </summary>
    public class BubbleSort
    {
        private int[] _array;

        /// <summary>
        /// Gets or sets the array to be sorted.
        /// </summary>
        public int[] Array
        {
            get => _array;
            set => _array = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the BubbleSort class.
        /// </summary>
        /// <param name="array">The array to be sorted.</param>
        public BubbleSort(int[] array)
        {
            Array = array;
        }

        /// <summary>
        /// Sorts the array using the bubble sort algorithm in ascending order.
        /// </summary>
        /// <returns>The sorted array.</returns>
        public int[] Sort()
        {
            if (_array == null || _array.Length <= 1)
                return _array;

            int n = _array.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (_array[j] > _array[j + 1])
                    {
                        // Swap elements
                        Swap(j, j + 1);
                        swapped = true;
                    }
                }

                // If no swapping occurred, the array is already sorted
                if (!swapped)
                    break;
            }

            return _array;
        }

        /// <summary>
        /// Sorts the array using the bubble sort algorithm in descending order.
        /// </summary>
        /// <returns>The sorted array in descending order.</returns>
        public int[] SortDescending()
        {
            if (_array == null || _array.Length <= 1)
                return _array;

            int n = _array.Length;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (_array[j] < _array[j + 1])
                    {
                        // Swap elements
                        Swap(j, j + 1);
                        swapped = true;
                    }
                }

                // If no swapping occurred, the array is already sorted
                if (!swapped)
                    break;
            }

            return _array;
        }

        /// <summary>
        /// Swaps two elements in the array at the specified indices.
        /// </summary>
        /// <param name="index1">The first index.</param>
        /// <param name="index2">The second index.</param>
        private void Swap(int index1, int index2)
        {
            int temp = _array[index1];
            _array[index1] = _array[index2];
            _array[index2] = temp;
        }

        /// <summary>
        /// Gets the current state of the array as a string representation.
        /// </summary>
        /// <returns>A string representation of the array.</returns>
        public override string ToString()
        {
            return _array != null ? $"[{string.Join(", ", _array)}]" : "[]";
        }

        /// <summary>
        /// Creates a copy of the current array.
        /// </summary>
        /// <returns>A copy of the array.</returns>
        public int[] GetCopy()
        {
            if (_array == null)
                return null;

            int[] copy = new int[_array.Length];
            System.Array.Copy(_array, copy, _array.Length);
            return copy;
        }
    }
}
