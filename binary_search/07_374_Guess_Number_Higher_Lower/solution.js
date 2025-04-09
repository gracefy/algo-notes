// 374. Guess Number Higher or Lower
// Https://leetcode.com/problems/guess-number-higher-or-lower/
// Difficulty: Easy
// Tags: Binary Search

/** 
 * Forward declaration of guess API.
 * @param {number} num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * var guess = function(num) {}
 */

/**
 * @param {number} n
 * @return {number}
 */
var guessNumber = function (n) {
  let left = 1
  let right = n

  while (left <= right) {
    const mid = Math.floor((left + right) / 2)
    const num = guess(mid)

    if (num === 0) {
      return mid
    } else if (num === -1) {
      right = mid - 1
    } else if (num === 1) {
      left = mid + 1
    }
  }
};

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