namespace SearchLibrary.Algorithms
{
    public class InterpolationSearch
    {
        public int Search(int key, int[] elemArray)
        {
            if (elemArray == null || elemArray.Length == 0)
                return -1;

            int low = 0;
            int high = elemArray.Length - 1;

            while (low <= high && key >= elemArray[low]
                               && key <= elemArray[high])
            {
                if (elemArray[high] == elemArray[low])
                {
                    if (elemArray[low] == key) return low;
                    else return -1;
                }

                int pos = low + ((key - elemArray[low]) * (high - low))
                               / (elemArray[high] - elemArray[low]);

                if (elemArray[pos] == key) return pos;
                if (elemArray[pos] < key) low = pos + 1;
                else high = pos - 1;
            }
            return -1;
        }
    }
}