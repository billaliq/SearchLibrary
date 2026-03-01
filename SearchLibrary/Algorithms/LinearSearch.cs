namespace SearchLibrary.Algorithms
{
    public class LinearSearch
    {
        public int Search(int key, int[] elemArray)
        {
            if (elemArray == null || elemArray.Length == 0)
                return -1;

            for (int i = 0; i < elemArray.Length; i++)
            {
                if (elemArray[i] == key)
                    return i;
            }
            return -1;
        }
    }
}