namespace Permutation;
public class Class1
{
    public void NextPermutation(int[] nums)
    {
        int firstIndex = nums.Length - 2;

        while (firstIndex >= 0 && nums[firstIndex] >= nums[firstIndex + 1])
        {
            firstIndex--;
        }

        if (firstIndex < 0)
        {
            Array.Reverse(nums);
            return;
        }


        int secondIndex = nums.Length - 1;

        while (secondIndex >= firstIndex && nums[secondIndex] <= nums[firstIndex])
        {
            secondIndex--;
        }

        int temp = nums[firstIndex];
        nums[firstIndex] = nums[secondIndex];
        nums[secondIndex] = temp;


        int start = firstIndex + 1;
        int end = nums.Length - 1;

        while (start < end)
        {
            int temp2 = nums[start];
            nums[start] = nums[end];
            nums[end] = temp2;
            start++;
            end--;
        }
    }
}
