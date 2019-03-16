public class Solution {
    public int[] TwoSum(int[] nums, int target) {

     int[] res = new int[2];
     for (int i = 0; i < nums.Length-1; i++) {
         int n1 = nums[i];
         int n2 = target - n1;
         for (int j = i+1; j < nums.Length; j++) {
             if (nums[j] == n2) {
                 res[0] = i;
                 res[1] = j;
                 return res;
             }
         }
     }
     return res;
    }
}

