function AnotherFunction() {
  // some logic
}

// 2 + n + n + 1 => 3 + 2n => 2n => n | worst-case, drop constants
// O(n)
function FunChallenge(input) {
  a = 10; // O(1)
  a = 50 + 3; // O(1)

  for (let i = 0; i < input.length; i++) { // worst-case
    AnotherFunction(); // O(n) 
    let stranger = true; // O(n)
    a = a+1; // O(n)
  }

  for (let i = 0; i < input.length; i++) {
    AnotherFunction(); // O(n)
  }
  
  return a; // O(1)
}

// 1+1+1+1+1 => 5 => 1
// O(1)
function PrintFirstFiveItems(input) {
    console.log(input[0]); // O(1)
    console.log(input[1]); // O(1)
    console.log(input[2]); // O(1)
    console.log(input[3]); // O(1)
    console.log(input[4]); // O(1)
}

const lst = [1,2,3,4,5];
console.log(FunChallenge(lst));
PrintFirstFiveItems(lst);