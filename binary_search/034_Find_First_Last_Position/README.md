# 34. Find First and Last Position of Element in Sorted Array

**Difficulty:** Medium  
**Tags:** Array, Binary Search  
**LeetCode link:** [https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array]

## Approach

Use binary search twice:

1. Find the **first occurrence** of the target:

   - Continue search even after finding target
   - Move `right = mid - 1` to explore earlier matches

2. Find the **last occurrence** of the target:
   - Continue search even after finding target
   - Move `left = mid + 1` to explore later matches

If the target is not found in the first binary search, return `[-1, -1]`.

## Complexity

- **Time:** O(log n)
- **Space:** O(1)

---

## Notes

- Classic example of using binary search to find boundaries
