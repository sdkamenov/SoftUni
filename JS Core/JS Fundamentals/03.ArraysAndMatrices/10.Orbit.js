function solve(input) {
    let rows = input[0];
    let cols = input[1];
    let x = input[2];
    let y = input[3];

    let matrix = [];
    for (let i = 0; i < rows; i++) {
        matrix.push([]);
    }

    for (let row = 0; row < rows; row++) {
        for (let col = 0; col < cols; col++) {
            matrix[row][col] = Math.max(Math.abs(row - x), Math.abs(col - y)) + 1
        }
    }

    console.log(matrix.map(e => e.join(' ')).join("\n"));

}
solve([4, 4, 0, 0])
solve([5, 5, 2, 2])