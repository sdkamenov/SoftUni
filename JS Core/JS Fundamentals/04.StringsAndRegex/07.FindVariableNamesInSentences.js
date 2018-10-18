function solve(input) {
    let result = [];
    let reg = /\b_([a-zA-Z\d]+)\b/g;
    let exec;
    while (exec = reg.exec(input)) {
        result.push(exec[1]);
    }
    console.log(result.join(","));
}
solve('The _id and _age variables are both integers.')