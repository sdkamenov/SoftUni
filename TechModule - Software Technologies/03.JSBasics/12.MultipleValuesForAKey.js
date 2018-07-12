function solve(array) {
    let result = [];
    let keyToFind = array[array.length - 1];

    for (let i = 0; i < array.length - 1; i++) {
        let splitted = array[i].split(" ");
        let key = splitted[0];
        let value = splitted[1];
        if (result[key] === undefined) {
            result[key] = [];
            result[key].push(value);
        } else {
            result[key].push(value);
        }
    }

    if (result[keyToFind] === undefined) {
        console.log("None")
    } else {
        let x = result[keyToFind];
        console.log(x.join("\n"));
    }
}