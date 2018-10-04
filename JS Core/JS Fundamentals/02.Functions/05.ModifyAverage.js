function solve(number) {
    let numberAsString = number.toString();
    let finalSum = sumDigits(numberAsString);


    function sumDigits(number) {
        let sumOfDigits = 0;
        for (const digit of number) {
            sumOfDigits += +digit;
        }
        return sumOfDigits;
    }

    while (finalSum / numberAsString.length <= 5) {
        numberAsString += '9';
        finalSum = sumDigits(numberAsString);
    }
    console.log(numberAsString);
}
solve(101)