/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var searchInsert = function (nums, target) {
  let left = 0;
  let right = nums.length - 1;

  while (left <= right) {
    const mid = left + Math.floor((right - left) / 2);

    if (nums[mid] === target) {
      return mid;
    } else if (nums[mid] < target) {
      left = mid + 1;
    } else {
      right = mid - 1;
    }
  }

  return left;
};

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
