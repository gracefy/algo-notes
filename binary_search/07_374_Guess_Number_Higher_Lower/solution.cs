// 374. Guess Number Higher or Lower
// Https://leetcode.com/problems/guess-number-higher-or-lower/
// Difficulty: Easy
// Tags: Binary Search

/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame
{
  public int GuessNumber(int n)
  {
    int left = 1;
    int right = n;

    while (left <= right)
    {
      int mid = left + (right - left) / 2;
      int result = guess(mid);

      if (result == 0)
      {
        return mid;
      }
      else if (result == -1)
      {
        right = mid - 1;
      }
      else
      {
        left = mid + 1;
      }
    }

    return -1;
  }
}

/*
Example 1:

Input: n = 10, pick = 6
Output: 6
Example 2:

Input: n = 1, pick = 1
Output: 1
Example 3:

Input: n = 2, pick = 1
Output: 1
*/