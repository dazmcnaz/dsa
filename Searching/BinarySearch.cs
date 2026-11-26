namespace dsa_repo.Searching
{
    public static class BinarySearch
    {
        public static int Search(int[] arr, int target)
        {
            int low = 0, high = arr.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }

                if (arr[mid] < target) 
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return -1;
        }

        public static int SearchRecursive(int[] arr, int target)
        {
            return SearchRecursive(arr, target, 0, arr.Length - 1);
        }

        private static int SearchRecursive(int[] arr, int target, int low, int high)
        {
            if (low > high)
            {
                return -1;
            }

            int mid = low + (high - low) / 2;

            if (arr[mid] == target)
            {
                return mid;
            }

            if (arr[mid] > target)
            {
                return SearchRecursive(arr, target, low, mid - 1);
            }

            return SearchRecursive(arr, target, mid + 1, high);
        }
    }
}
