function solve(input) {
    let delimiter = input[input.length - 1];
    input.pop();

    console.log(input.join(delimiter));

}
solve(['One',
    'Two',
    'Three',
    'Four',
    'Five',
    '-'
])