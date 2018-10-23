function solve(input) {
    let uniqueSequence = new Map();

    for (let item of input) {
        let sequence = JSON.parse(item).map(Number).sort((a, b) => b - a);
        if (!uniqueSequence.has(sequence.length)) {
            uniqueSequence.set(sequence.length, new Set());
        }
        uniqueSequence.get(sequence.length).add(`[${sequence.join(", ")}]`);
    }

    let lengthKeys = Array.from(uniqueSequence.keys()).sort((a, b) => a - b);

    let result = [];
    for (let len of lengthKeys) {
        for (const sequence of uniqueSequence.get(len)) {
            result.push(sequence)
        }
    }

    console.log(result.join("\n"));

}

solve([
    "[-3, -2, -1, 0, 1, 2, 3, 4]",
    "[10, 1, -17, 0, 2, 13]",
    "[4, -3, 3, -2, 2, -1, 1, 0]"
])