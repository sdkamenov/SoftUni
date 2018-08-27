function solve(array) {
    let number1 = Number(array[0]);
    let number2 = Number(array[1]);
    let number3 = Number(array[2]);
    let counter = 0;

    if (number1 < 0) {
        counter++;
    }
    if (number2 < 0) {
        counter++;
    }
    if (number3 < 0) {
        counter++;
    }
    if (number3 === 0 || number2 === 0 || number1 === 0) {
        return "Positive";
    }
    if (counter === 0 || counter === 2) {
        return "Positive";
    } else{
        return "Negative"
    }
}