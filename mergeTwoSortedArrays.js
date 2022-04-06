// mergeSortedArray([0, 3, 4, 31], [4, 6, 30]);
// [0,3,4,4,6,30,31]

// function mergeSortedArray(arr1, arr2) {
//   if (arr1.length === 0) return arr2;
//   if (arr2.length === 0) return arr1;

//   arr1Item = arr1[0];
//   arr2Item = arr2[0];

//   var mergedArr = [];
//   var i = 1;
//   var j = 1;
//   while (arr1Item || arr2Item) {
//     if (!arr2Item || arr1Item < arr2Item) {
//       mergedArr.push(arr1Item);
//       arr1Item = arr1[i];
//       i++;
//     } else {
//       mergedArr.push(arr2Item);
//       arr2Item = arr2[j];
//       j++;
//     }
//   }
//   return mergedArr;
// }

// console.log(mergeSortedArray([0, 3, 4, 31], [4, 6, 30]));

var merge = function (nums1, m, nums2, n) {
  m--;
  n--;
  let i = nums1.length - 1;
  while (i >= 0) {
    if (n > -1 && m > -1 && nums1[m] >= nums2[n]) {
      nums1[i] = nums1[m];
      nums1[m] = nums2[n];
      m--;
    } else if (n > -1) {
        nums1[i] = nums2[n--];
        console.log(n);
        nums2[n--];
        console.log(n);
        console.log(nums1[i]);
    }
    i--;
    }
    console.log(nums1);
};

merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
