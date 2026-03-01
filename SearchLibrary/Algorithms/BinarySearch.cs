namespace SearchLibrary.Algorithms
{
    public class BinarySearch
    {
        public int Search(int key, int[] elemArray)
        {
            int bottom = 0; int top = elemArray.Length - 1;
            int mid; int index = -1; bool found = false;
            while (bottom <= top && found == false)
            {
                mid = (top + bottom) / 2;
                if (elemArray[mid] == key)
                {
                    index = mid; found = true; return index;
                }
                else
                {
                    if (elemArray[mid] < key)
                        bottom = mid + 1;
                    else
                        top = mid - 1;
                }
            }
            return index;
        }
    }
}