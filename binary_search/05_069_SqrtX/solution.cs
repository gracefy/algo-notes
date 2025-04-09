// 69. Sqrt(x)
// https://leetcode.com/problems/sqrtx/
// Difficulty: Easy
// Tags: Binary Search

public class Solution
{
  public int MySqrt(int x)
  {
    int left = 1;
    int right = x;

    while (left <= right)
    {
      int mid = left + (right - left) / 2;
      long square = (long)mid * mid;

      if (square == x)
      {
        return mid;
      }
      else if (square > x)
      {
        right = mid - 1;
      }
      else
      {
        left = mid + 1;
      }
    }

    return right;
  }
}

/*
Example 1:

Input: x = 4
Output: 2
Explanation: The square root of 4 is 2, so we return 2.
Example 2:

Input: x = 8
Output: 2
Explanation: The square root of 8 is 2.82842..., and since we round it down to the nearest integer, 2 is returned.
*/