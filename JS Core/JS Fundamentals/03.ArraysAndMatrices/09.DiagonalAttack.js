function solve(input) {
    let matrix = input
        .map(row => row
            .split(' ')
            .map(n => +n));

    let mainDiagonal = 0;
    let secondaryDiagonal = 0;

    for (let row = 0; row < matrix.length; row++) {
        mainDiagonal += matrix[row][row];
        secondaryDiagonal += matrix[row][matrix.length - row - 1];
    }

    if (mainDiagonal === secondaryDiagonal) {

        for (let row = 0; row < matrix.length; row++) {
            for (let col = 0; col < matrix.length; col++) {
                if (col !== row && col !== (matrix.length - row - 1)) {
                    matrix[row][col] = mainDiagonal;
                }
            }
        }
    }

    console.log(matrix.map(e => e.join(' ')).join("\n"));

}

solve(['5 3 12 3 1',
    '11 4 23 2 5',
    '101 12 3 21 10',
    '1 4 5 2 2',
    '5 22 33 11 1'
])