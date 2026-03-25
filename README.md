# Trapping Rainwater — LeetCode 42

[![Instagram](https://img.shields.io/badge/Instagram-%40lacopydepastel-E4405F?style=for-the-badge&logo=instagram&logoColor=white)](https://www.instagram.com/lacopydepastel)
[![YouTube](https://img.shields.io/badge/YouTube-%40rvorine-FF0000?style=for-the-badge&logo=youtube&logoColor=white)](https://www.youtube.com/@rvorine)

---

## 📖 Problem Description

Given `n` non-negative integers representing an elevation map where the width of each bar is `1`, compute how much water it can trap after raining.

**Example 1:**
```
Input:  height = [0,1,0,2,1,0,1,3,2,1,2,1]
Output: 6
```
```
       ■
   ■~~~■ ■~■
 ■ ■ ■ ■ ■ ■ ■ ■
─────────────────
```

**Example 2:**
```
Input:  height = [4,2,0,3,2,5]
Output: 9
```

**Constraints:**
- `n == height.length`
- `1 <= n <= 2 * 10⁴`
- `0 <= height[i] <= 10⁵`

---

## 💡 Solution — Two Pointer Approach

The most optimal approach is the **two-pointer technique**:

1. Place a `left` pointer at the start and a `right` pointer at the end.
2. Keep track of `maxLeft` and `maxRight` — the maximum heights seen from each side.
3. At each step, move the pointer pointing at the smaller height inward:
   - If the current bar is shorter than the running max on that side, it can trap water equal to `max - height[i]`.
   - Otherwise, update the running max.
4. Accumulate the trapped water and return the total.

**Time Complexity:** O(n)  
**Space Complexity:** O(1)

---

## 🗂️ Repository Structure

```
trapping-rainwater/
├── kotlin/
│   └── src/
│       └── TrappingRainwater.kt
├── java/
│   └── src/
│       └── TrappingRainwater.java
├── csharp/
│   └── src/
│       └── TrappingRainwater.cs
├── python/
│   └── trapping_rainwater.py
└── javascript/
    └── trappingRainwater.js
```

---

## 🚀 Running the Solutions

### Kotlin
```bash
cd kotlin/src
kotlinc TrappingRainwater.kt -include-runtime -d TrappingRainwater.jar
java -jar TrappingRainwater.jar
```

### Java
```bash
cd java/src
javac TrappingRainwater.java
java TrappingRainwater
```

### C#
```bash
cd csharp/src
dotnet-script TrappingRainwater.cs
# or: csc TrappingRainwater.cs && mono TrappingRainwater.exe
```

### Python
```bash
cd python
python trapping_rainwater.py
```

### JavaScript
```bash
cd javascript
node trappingRainwater.js
```
