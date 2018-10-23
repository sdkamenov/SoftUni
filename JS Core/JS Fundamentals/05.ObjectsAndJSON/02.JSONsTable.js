function solve(input) {
    let output = "<table>\n";

    for (let line of input) {
        output += "\t<tr>\n";
        let token = JSON.parse(line);
        Object.entries(token).forEach(([k, v]) => {
            output += `\t\t<td>${v}</td>\n`
        });
        output += "\t</tr>\n";
    }
    output += "</table>\n"

    console.log(output);

}

solve(
    [
        '{"name":"Pesho","position":"Promenliva","salary":100000}',
        '{"name":"Teo","position":"Lecturer","salary":1000}',
        '{"name":"Georgi","position":"Lecturer","salary":1000}'
    ]
)