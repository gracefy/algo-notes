# 35. Search Insert Position

**Difficulty:** Easy
**Tags:** Array, Binary Search
**Leetcode link:** [https://leetcode.com/problems/search-insert-position/]

> Languages: JavaScript, C#

## Approach

We use binary search to locate the target or its insert position.
After the loop ends, `left` points to the first index where `target` could be inserted:

- If `target` exists → we already returned `mid`
- If not → `left` becomes the insert point

## Complexity

- Time: O(log n)
- Space: O(1)

## Notes

Implemented in both JS and C# for practice.
