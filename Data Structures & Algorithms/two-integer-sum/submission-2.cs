public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> seen = new Dictionary<int,int>();

        for (int i=0;i<nums.Length;i++)
        {
            int num = nums[i];
            int comp = target - num;
            if(seen.ContainsKey(comp))
                return new int[]{seen[comp],i};
            seen[num]= i;

        }
        return new int[0];

    }
}
