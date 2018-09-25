function solve(number) {
    let length = number % 2 == 0 ? number - 1 : number;

    for (let i = 1; i <= length; i++) {
        if (i == 1 || i == length || (length + 1) / i == 2) {
            console.log("+" + "-".repeat(number - 2) + "+" + "-".repeat(number - 2) + "+");
        } else {
            console.log("|" + " ".repeat(number - 2) + "|" + " ".repeat(number - 2) + "|");
        }
    }
}
solve(4)