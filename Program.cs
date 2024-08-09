﻿//*****************************************************************************
//** 16. 3Sum Closest  leetcode                                              **
//** Sorted Array, ran a loop to find the closest sum                        **
//*****************************************************************************

// Comparator function for qsort to sort integers
int compare(const void* a, const void* b) {
    return (*(int*)a - *(int*)b);
    }

int threeSumClosest(int* nums, int numsSize, int target) {
    // Sort the array using qsort
    qsort(nums, numsSize, sizeof(int), compare);

    int closestSum = nums[0] + nums[1] + nums[2];

    for (int i = 0; i < numsSize - 2; i++) 
    {
        int left = i + 1;
        int right = numsSize - 1;

        while (left < right) 
        {
            int sum = nums[i] + nums[left] + nums[right];

            // If the exact target sum is found, return it immediately
            if (sum == target) 
            {
                return sum;
            }

            // Update the closest sum if the current one is closer to the target
            if (abs(sum - target) < abs(closestSum - target)) 
            {
                closestSum = sum;
            }

            // Adjust the pointers based on the comparison of sum and target
            if (sum < target) 
            {
                left++;
            }
            else 
            {
                right--;
            }
        }
    }

    return closestSum;
}
