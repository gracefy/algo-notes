

/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl
{
  public int FirstBadVersion(int n)
  {
    int left = 1;
    int right = n;

    while (left < right)
    {
      int mid = left + (right - left) / 2;
      bool result = IsBadVersion(mid);

      if (result)
      {
        right = mid;
      }
      else
      {
        left = mid + 1;
      }
    }

    return left;

  }
}

/*
Example 1:

Input: n = 5, bad = 4
Output: 4
Explanation:
call isBadVersion(3) -> false
call isBadVersion(5) -> true
call isBadVersion(4) -> true
Then 4 is the first bad version.
Example 2:

Input: n = 1, bad = 1
Output: 1
*/