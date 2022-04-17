//Google Question
//Given an array = [2,5,1,2,3,5,1,2,4]:
//It should return 2

//Given an array = [2,1,1,2,3,5,1,2,4]:
//It should return 1

//Given an array = [2,3,4,5]:
//It should return undefined

function firstRecurringCharacter(input) {
  var result;
  var recurringSet = new Set();
  for (var i = 0; i < input.length; i++) {
    if (recurringSet.has(input[i])) {
      return input[i];
    } else {
      recurringSet.add(input[i]);
    }
  }
  return undefined;
  // O(n)
}

var result = firstRecurringCharacter([2, 5, 5, 2, 3, 5, 1, 2, 4]);
console.log(result);
//Bonus... What if we had this:
// [2,5,5,2,3,5,1,2,4]
// return 5 because the pairs are before 2,2
