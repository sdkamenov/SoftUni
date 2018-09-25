function solve(array) {
    let object = {};
    object[array[0]] = array[1];
    object[array[2]] = array[3];
    object[array[4]] = array[5];

    console.log(object);
}
solve(['name', 'Pesho', 'age', '23', 'gender', 'male'])