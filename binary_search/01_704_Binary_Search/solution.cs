// 704. Binary Search
// https://leetcode.com/problems/binary-search/
// Difficulty: Easy
// Tags: Array, Binary Search


public class Solution
{
  public int Search(int[] nums, int target)
  {

    int left = 0;
    int right = nums.Length - 1;

    while (left <= right)
    {
      int mid = (left + right) / 2;

      if (nums[mid] == target)
      {
        return mid;
      }
      else if (nums[mid] < target)
      {
        left = mid + 1;
      }
      else
      {
        right = mid - 1;
      }
    }
    return -1;
  }
}

/*
Example 1:

Input: nums = [-1,0,3,5,9,12], target = 9
Output: 4
Explanation: 9 exists in nums and its index is 4
Example 2:

Input: nums = [-1,0,3,5,9,12], target = 2
Output: -1
Explanation: 2 does not exist in nums so return -1
*/