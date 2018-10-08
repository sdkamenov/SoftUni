function solve(input) {
    let matrix = input.slice(0);
    let sum = matrix[0].reduce((acc, cur) => acc + cur);

    for (let row = 0; row < matrix.length; row++) {
        let rowSum = matrix[row].reduce((acc, cur) => acc + cur);
        let colSum = 0;

        if (rowSum != sum) {
            return false;
        }

        for (let col = 0; col < matrix.length; col++) {
            colSum += matrix[row][col];
        }

        if (colSum != sum) {
            return false;
        }
    }
    return true;
}