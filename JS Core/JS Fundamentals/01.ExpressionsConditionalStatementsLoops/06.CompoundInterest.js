function solve([P, i, n, t]) {
    let compoundInterest = P * Math.pow(1 + i / (100 * (12 / n)), 12 / n * t)
    console.log(compoundInterest);
}
solve([1500, 4.3, 3, 6])
solve([100000, 5, 12, 25])