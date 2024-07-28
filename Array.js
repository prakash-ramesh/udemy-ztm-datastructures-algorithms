// Arrays in JS are dynamic by default

const s = ['a', 'b', 'c', 'd'];

s.pop(); // O(1)

s.push('e'); // O(1)

s.unshift('x'); // O(n)