

public class Solution
{
  public bool IsPerfectSquare(int num)
  {
    int left = 1;
    int right = num;

    while (left <= right)
    {
      int mid = left + (right - left) / 2;
      long square = (long)mid * mid; // Use long to prevent overflow

      if (square == num)
      {
        return true;
      }
      else if (square < num)
      {
        left = mid + 1;
      }
      else
      {
        right = mid - 1;
      }
    }

    return false;
  }
}


/*
Example 1:

Input: num = 16
Output: true
Explanation: We return true because 4 * 4 = 16 and 4 is an integer.
Example 2:

Input: num = 14
Output: false
Explanation: We return false because 3.742 * 3.742 = 14 and 3.742 is not an integer.
*/
