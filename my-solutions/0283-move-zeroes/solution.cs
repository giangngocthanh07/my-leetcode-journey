public class Solution {
    public void MoveZeroes(int[] nums) {
        int insertPo = 0;
        int temp = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                temp = nums[i];
                nums[i] = nums[insertPo];
                nums[insertPo] = temp;
                insertPo++;
            }
            else
            {
                continue;
            }
        }
    }
}
//     0, 1, 0, 3
// i = 0, 1, 2, 3
// insertPo = 0;

// if (nums[i] != 0)
//  temp = nums[i];
//  nums[i] = nums[insertPo];
//  nums[insertPo] = temp;
//  insertPo++;
//  else => continue;

// 1, 0, 2
