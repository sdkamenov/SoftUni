function solve(input) {
    let xml = '<?xml version="1.0" encoding="UTF-8"?>\n<quiz>\n';

    for (let i = 0; i < input.length; i += 2) {
        xml += `\t<question>\n\t\t${input[i]}\n\t</question>\n`;
        xml += `\t<answer>\n\t\t${input[i+1]}\n\t</answer>\n`;

    }
    xml += '</quiz>';
    console.log(xml);
}