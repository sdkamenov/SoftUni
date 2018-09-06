function solve(array) {
    let length = Number(array[0]);
    let result = [];

    for (let i = 0; i < length; i++) {
        result[i] = 0;
    }

    for (let i = 1; i < array.length; i++) {
        let splitted = array[i].split(" - ");
        let index = splitted[0];
        let value = splitted[1];
        result[index] = value;
    }

    for (let i = 0; i < result.length; i++) {
        console.log(result[i]);
    }
}

solve(["5", "0 - 3", "3 - -1", "4 - 2",])