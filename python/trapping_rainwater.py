"""
LeetCode 42 - Trapping Rain Water

Given n non-negative integers representing an elevation map where the width of each bar is 1,
compute how much water it can trap after raining.

Approach: Two-pointer technique — O(n) time, O(1) space
"""
from typing import List


def trap(height: List[int]) -> int:
    left, right = 0, len(height) - 1
    max_left, max_right = 0, 0
    water = 0

    while left < right:
        if height[left] < height[right]:
            if height[left] >= max_left:
                max_left = height[left]
            else:
                water += max_left - height[left]
            left += 1
        else:
            if height[right] >= max_right:
                max_right = height[right]
            else:
                water += max_right - height[right]
            right -= 1

    return water


if __name__ == "__main__":
    print(trap([0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]))  # Expected: 6
    print(trap([4, 2, 0, 3, 2, 5]))                      # Expected: 9
