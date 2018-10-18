function solve(string, delimiter) {
    let result = string.split(delimiter).join("\n");
    console.log(result);
}

solve('One-Two-Three-Four-Five', '-')