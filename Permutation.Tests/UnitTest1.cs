namespace Permutation.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;
    public UnitTest1() 
    {
        _test = new Class1();
    }
    [TestMethod]
    public void TestMethod1()
    {
        int[] nums = { 1, 2, 3 };
        _test.NextPermutation(nums);
        int[] answer = { 1, 3, 2 };
        bool isEqual = true;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != answer[i])
            {
                isEqual= false;
            }
        }

        Assert.IsTrue(isEqual);
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        int[] nums = { 3, 2, 1 };
        _test.NextPermutation(nums);
        int[] answer = { 1, 2, 3 };
        bool isEqual = true;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != answer[i])
            {
                isEqual= false;
            }
        }

        Assert.IsTrue(isEqual);
    }  
    
    [TestMethod]
    public void TestMethod3()
    {
        int[] nums = { 1, 1, 5 };
        _test.NextPermutation(nums);
        int[] answer = { 1, 5, 1 };
        bool isEqual = true;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != answer[i])
            {
                isEqual= false;
            }
        }

        Assert.IsTrue(isEqual);
    }
}