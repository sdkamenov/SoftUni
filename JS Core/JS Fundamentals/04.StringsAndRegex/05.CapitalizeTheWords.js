function solve(input) {
    let result = input.split(" ").map(w => w.charAt(0).toUpperCase() + w.slice(1).toLowerCase());
    console.log(result.join(" "));
}

solve('Capitalize these words')