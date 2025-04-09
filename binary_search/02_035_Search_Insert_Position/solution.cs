// 35. Search Insert Position
// https://leetcode.com/problems/search-insert-position/
// Difficulty: Easy
// Tags: Array, Binary Search

public class Solution
{
  public int SearchInsert(int[] nums, int target)
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

    return left;

  }
}

/*
Example 1:

Input: nums = [1, 3, 5, 6], target = 5
Output: 2
Example 2:

Input: nums = [1, 3, 5, 6], target = 2
Output: 1
Example 3:

Input: nums = [1, 3, 5, 6], target = 7
Output: 4
*/