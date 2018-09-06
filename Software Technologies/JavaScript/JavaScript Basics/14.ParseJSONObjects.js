function solve(array) {
    for (let line of array){
        let obj = JSON.parse(line);
        for (let key in obj){
            console.log(key[0].toUpperCase() + key.substr(1) + ": " + obj[key]);
        }
    }
}