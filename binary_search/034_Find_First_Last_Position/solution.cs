

public class Solution
{
  public int[] SearchRange(int[] nums, int target)
  {

    if (nums.Length == 0 || target < nums[0] || target > nums[nums.Length - 1])
    {
      return new int[] { -1, -1 };
    }

    int firstIndex = FindFirst(nums, target);
    int lastIndex = FindLast(nums, target);

    return new int[] { firstIndex, lastIndex };

  }

  private int FindFirst(int[] nums, int target)
  {
    int left = 0;
    int right = nums.Length - 1;
    int index = -1;

    while (left <= right)
    {
      int mid = (left + right) / 2;

      if (nums[mid] == target)
      {
        index = mid;
        right = mid - 1;
      }
      else if (nums[mid] > target)
      {
        right = mid - 1;
      }
      else
      {
        left = mid + 1;
      }
    }

    return index;
  }

  private int FindLast(int[] nums, int target)
  {
    int left = 0;
    int right = nums.Length - 1;
    int index = -1;

    while (left <= right)
    {
      int mid = (left + right) / 2;

      if (nums[mid] == target)
      {
        index = mid;
        left = mid + 1;
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

    return index;
  }
}

/*
Example 1:

Input: nums = [5,7,7,8,8,10], target = 8
Output: [3,4]
Example 2:

Input: nums = [5,7,7,8,8,10], target = 6
Output: [-1,-1]
Example 3:

Input: nums = [], target = 0
Output: [-1,-1]

*/