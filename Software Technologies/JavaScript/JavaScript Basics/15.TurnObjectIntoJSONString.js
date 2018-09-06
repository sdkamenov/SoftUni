function solve(arr) {
    let obj = {};
    for (let i = 0; i < arr.length; i++) {
        let splitted = arr[i].split(" -> ");
        let key = splitted[0];
        let value = splitted[1];
        if (!isNaN(Number(value))) {
            obj[key] = Number(value);
        } else {
            obj[key] = value;
        }
    }
    console.log(JSON.stringify(obj));
}