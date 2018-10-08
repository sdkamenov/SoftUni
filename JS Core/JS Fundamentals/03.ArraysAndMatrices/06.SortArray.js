function solve(input) {
    function compare(a, b) {
        if (a.length > b.length) {
            return 1;
        } else if (a.length < b.length) {
            return -1;
        } else {
            if (a < b) {
                return -1;
            } else if (a > b) {
                return 1;
            } else {
                return 0;
            }
        }
    }

    console.log(input.sort(compare).join("\n"));

}

// function solve(arr) {
//     arr.sort(function (a, b) {
//         if (a.length != b.length) {
//             return a.length - b.length;
//         }
//         if (a.length == b.length) {
//             return a.toLowerCase().localeCompare(b.toLowerCase());
//         }
//     });
//     console.log(arr.join("\n"));
// }

solve(['alpha',
    'beta',
    'gamma'
])