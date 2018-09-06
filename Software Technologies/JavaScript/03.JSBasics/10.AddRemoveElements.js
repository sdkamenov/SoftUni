function solve(array) {
    let result = [];
    for (let i = 0; i < array.length; i++) {
        let splitted = array[i].split(" ");
        let command = splitted[0];
        let value = Number(splitted[1]);
        if (command === "add") {
            result.push(value);
        }
        if (command === "remove") {
            result.splice(value, 1);
        }
    }

    for (let number of result){
        console.log(number);
    }
}