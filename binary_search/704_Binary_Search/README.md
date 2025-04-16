# 704. Binary Search

**Difficulty:** Easy
**Tags:** Array, Binary Search
**Leetcode link:** [https://leetcode.com/problems/binary-search/]

> Languages: JavaScript, C#

## Approach

- Classic binary search, iterative version.
- Track left and right pointers.
- Check mid, shrink the search space.

## Notes

It’s safer to write `left + (right - left) / 2` instead of `(left + right) / 2` in languages with fixed-size integers (like Java, C++, or c#) to avoid integer overflow.

## Complexity

- Time: O(log n)
- Space: O(1)

## Notes

Implemented in both JS and C# for practice.
