function solve(array) {
    let number1 = Number(array[0]);
    let number2 = Number(array[1]);

    if (number1 > number2) {
        return number1 / number2
    } else {
        return number1 * number2
    }
}