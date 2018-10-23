function solve(input) {
    let pool = {};
    let totalScore = '%totalScore%';
    for (let line of input) {
        if (line.includes('->')) {
            let [name, technique, score] = line.split(/ -> /);

            if (!pool.hasOwnProperty(name)) {
                pool[name] = {};
                pool[name][totalScore] = 0;
            }

            if (!pool[name].hasOwnProperty(technique)) {
                pool[name][technique] = +score;
                pool[name][totalScore] += +score
            } else {
                if (pool[name][technique] < +score) {
                    let previousScore = pool[name][technique];
                    pool[name][technique] = +score;
                    pool[name][totalScore] += +score - previousScore;
                }
            }
        } else if (line.includes(' vs ')) {
            let [firstGl, secondGl] = line.split(/ vs /);
            let first = pool[firstGl];
            let second = pool[secondGl];

            if (pool.hasOwnProperty(firstGl) && pool.hasOwnProperty(secondGl)) {
                let found = false
                Object.keys(first)
                    .forEach((key) => {
                        if (found) {
                            return;
                        }
                        if (key !== totalScore && pool[secondGl].hasOwnProperty(key)) {
                            if (first[totalScore] > second[totalScore]) {
                                delete pool[secondGl];
                                found = true;
                            } else if (first[totalScore] < second[totalScore]) {
                                delete pool[firstGl];
                                found = true;
                            }
                        }
                    });
            } else {
                break;
            }
        } else {
            break;
        }
    }

    let sortedKeys = Object
        .keys(pool)
        .sort((a, b) =>
            pool[b][totalScore] - pool[a][totalScore] || a.localeCompare(b));

    let result = [];
    for (const key of sortedKeys) {
        result.push(`${key}: ${ pool[key][totalScore]} skill`)

        let sortedTechiques = Object
            .keys(pool[key])
            .filter(t => t != totalScore)
            .sort((a, b) =>
                +pool[key][b] - +pool[key][a] || a.localeCompare(b));

        for (const tech of sortedTechiques) {
            result.push(`- ${tech} <!> ${pool[key][tech]}`)
        }
    }

    console.log(result.join('\n'));
}


solve([
    'Pesho -> BattleCry -> 400',
    'Gosho -> PowerPunch -> 300',
    'Stamat -> Duck -> 200',
    'Stamat -> Tiger -> 250',
    'Ave Cesar'
])