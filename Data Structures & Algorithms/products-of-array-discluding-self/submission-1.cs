public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int [] productList = new int[n];
        int prefix=1, suffix = 1;
        for (int i=0;i<n;i++)
        {
            productList[i]=prefix;
            prefix*=nums[i];
        }
        for (int i =n-1;i>=0;i--)
        {
            productList[i]*=suffix;
            suffix*=nums[i];
        }
        return productList;
        
    }
}
