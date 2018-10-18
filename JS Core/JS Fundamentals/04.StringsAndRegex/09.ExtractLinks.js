function solve(input) {
    let regex = /www\.([A-Za-z0-9-]+)(\.[a-z]+)+/g;
    let result = [];
    let match;
    for (const inp of input) {
        while (match = regex.exec(inp)) {
            result.push(match[0]);
        }
    }
    console.log(result.join('\n'));

}