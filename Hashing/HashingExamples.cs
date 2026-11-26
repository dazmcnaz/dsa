namespace dsa_repo.Hashing
{
    public static class HashingExamples
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var seen = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (seen.TryGetValue(complement, out int complementIndex))
                {
                    return new int[] { complementIndex, i };
                }

                seen.TryAdd(nums[i], i);
            }

            return Array.Empty<int>();
        }

        public static char FirstUnique(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return '\0';
            }

            var counts = new Dictionary<char, int>();

            foreach (char c in s)
            {
                counts[c] = counts.GetValueOrDefault(c) + 1;
            }

            foreach (char c in s)
            {
                if (counts[c] == 1)
                {
                    return c;
                }
            }

            return '\0';
        }

    }
}
