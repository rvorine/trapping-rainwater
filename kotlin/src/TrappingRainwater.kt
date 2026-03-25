/**
 * LeetCode 42 - Trapping Rain Water
 *
 * Given n non-negative integers representing an elevation map where the width of each bar is 1,
 * compute how much water it can trap after raining.
 *
 * Approach: Two-pointer technique — O(n) time, O(1) space
 */
fun trap(height: IntArray): Int {
    var left = 0
    var right = height.size - 1
    var maxLeft = 0
    var maxRight = 0
    var water = 0

    while (left < right) {
        if (height[left] < height[right]) {
            if (height[left] >= maxLeft) {
                maxLeft = height[left]
            } else {
                water += maxLeft - height[left]
            }
            left++
        } else {
            if (height[right] >= maxRight) {
                maxRight = height[right]
            } else {
                water += maxRight - height[right]
            }
            right--
        }
    }

    return water
}

fun main() {
    println(trap(intArrayOf(0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1))) // Expected: 6
    println(trap(intArrayOf(4, 2, 0, 3, 2, 5)))                    // Expected: 9
}
