function solve(number) {
    for (let index = 0; index <= number; index++) {
        if (index % 2 != 0) {
            console.log(index);
        }
    }
}
solve(5)