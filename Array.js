// Arrays in JS are dynamic by default

const s = ['a', 'b', 'c', 'd'];

s.pop(); // O(1)

s.push('e'); // O(1)

s.unshift('x'); // O(n)

var twoSum = function(nums, target) {
    if(nums.length <= 1) {
        return null;
    }

    for(let i = 0; i < nums.length; i++)
    {
        let num_to_find = target - nums[i];
        for(let j = i+1; j < nums.length; j++)
        {
            if(num_to_find == nums[j])
            {
                return [i,j];
            }
        }
    }

    return null;
};