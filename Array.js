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

console.log(twoSum([3,2,4], 6))

var twoSum = function(nums, target) {
    if(nums.length <= 1) {
        return null;
    }

    ntfMap = {};

    for(let i = 0; i < nums.length; i++)
    {
        let num_to_find = target - nums[i];
        
        if (ntfMap[nums[i]] === undefined) {
            ntfMap[num_to_find] = i;
        } else {
            return [ntfMap[nums[i]], i];
        }
    }

    return null;
};

console.log(twoSum([2,7,11,15], 9))
console.log(twoSum([1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1], 11))