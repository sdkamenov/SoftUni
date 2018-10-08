function solve(input) {
    let array = [input[0]];

    for (let i = 1; i < input.length; i++) {
        if (input[i] >= array[array.length - 1]) {
            array.push(input[i]);
        }
    }

    console.log(array.join("\n"));

}

solve([1,
    3,
    8,
    4,
    10,
    12,
    3,
    2,
    24
])

solve([20,
    3,
    2,
    15,
    6,
    1
])