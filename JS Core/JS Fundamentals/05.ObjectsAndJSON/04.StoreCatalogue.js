function solve(input) {
    let catalogue = new Map();

    for (let item of input) {
        let [product, price] = item.split(" : ");
        let groupName = product.toUpperCase()[0];
        if (!catalogue.has(groupName)) {
            catalogue.set(groupName, new Map);
        }

        catalogue.get(groupName).set(product, +price);
    }

    let keys = [...catalogue.keys()].sort();
    let result = [];

    for (let key of keys) {
        result.push(key);
        let products = [...catalogue.get(key).keys()].sort();
        for (let product of products) {
            result.push(`  ${product}: ${catalogue.get(key).get(product)}`);
        }
    }

    console.log(result.join("\n"));

}

solve([
    'Appricot : 20.4',
    'Fridge : 1500',
    'TV : 1499',
    'Deodorant : 10',
    'Boiler : 300',
    'Apple : 1.25',
    'Anti-Bug Spray : 15',
    'T-Shirt : 10'
])