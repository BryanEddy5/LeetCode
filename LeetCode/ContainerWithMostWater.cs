using System;
using Xunit;

namespace LeetCode
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            var max = 0;
            var left = 0;
            var right = height.Length - 1;
            while (left <= right)
            {
                 max = Math.Max(ComputeArea(left, right, height), max);
                if (height[left] > height[right])
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return max;
        }

        private int ComputeArea(int left, int right, int[] height)
        {
            var min = Math.Min(height[left], height[right]);
            return min * (right - left);
        }

        [Theory]
        [InlineData(new [] {1,8,6,2,5,4,8,3,7}, 49)]
        public void Test(int[] input, int expected)
        {
            var actual = MaxArea(input);
            
            Assert.Equal(expected, actual);

        }
    }
}