public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> CheckDuplicate = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (CheckDuplicate.Contains(nums[i]))
            {
                return true;
            }
            else
            {
                CheckDuplicate.Add(nums[i]);
            }
        }
        return false;
    }
}
