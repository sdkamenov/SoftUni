function solve(input) {
    let text = input.join(" ")
    let regex = /\d+/g;
    let numbers = text.match(regex);
    console.log(numbers.join(" "));
}

solve(['123a456',
    '789b987',
    '654c321',
    '0'
])