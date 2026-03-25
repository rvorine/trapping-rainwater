/**
 * LeetCode 42 - Trapping Rain Water
 *
 * Given n non-negative integers representing an elevation map where the width of each bar is 1,
 * compute how much water it can trap after raining.
 *
 * Approach: Two-pointer technique — O(n) time, O(1) space
 *
 * @param {number[]} height
 * @return {number}
 */
function trap(height) {
    let left = 0, right = height.length - 1;
    let maxLeft = 0, maxRight = 0;
    let water = 0;

    while (left < right) {
        if (height[left] < height[right]) {
            if (height[left] >= maxLeft) {
                maxLeft = height[left];
            } else {
                water += maxLeft - height[left];
            }
            left++;
        } else {
            if (height[right] >= maxRight) {
                maxRight = height[right];
            } else {
                water += maxRight - height[right];
            }
            right--;
        }
    }

    return water;
}

// Examples
console.log(trap([0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1])); // Expected: 6
console.log(trap([4, 2, 0, 3, 2, 5]));                    // Expected: 9
