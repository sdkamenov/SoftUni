function solve(number) {
    let feet = number / 12;
    number = number % 12;
    console.log(`${Math.floor(feet)}'-${number}"`);
}
solve(36)
solve(55)
solve(11)