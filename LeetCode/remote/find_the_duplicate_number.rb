#   https://leetcode.com/problems/find-the-duplicate-number/
#   Given an array nums containing n + 1 integers where each integer is between 1 and n (inclusive),
#   prove that at least one duplicate number must exist. Assume that there is only one duplicate number, find the duplicate one.
#   https://leetcode.com/submissions/detail/55546970/
#
#   Submission Details
#   53 / 53 test cases passed.
#       Status: Accepted
#       Runtime: 156 ms
#           
#           Submitted: 0 minutes ago
def find_duplicate(nums)
    start = 1
    finish = nums.size - 1
    while start < finish
        mid = start + (finish - start) / 2
        count = nums.count { |x| x.between?(start, mid) }
        if count > mid - start + 1
            finish = mid
        else
            start = mid + 1
        end
    end
    
    start
end
