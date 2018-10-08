function solve(input) {
    let counter = 1;
    let array = [1];

    for (let i = 1; i < input.length; i++) {
        counter++;

        if (input[i] == "add") {
            array.push(counter);
        } else if (input[i] == "remove") {
            array.pop();
        }
    }

    if (array.length == 0) {
        console.log("Empty");
    } else {
        console.log(array.join("\n"));
    }

}
solve(['add',
    'add',
    'add',
    'add'
])
solve(['add',
    'add',
    'remove',
    'add',
    'add'
])