function solve(data, battles) {
    let kingdoms = {};
    for (let kingdomData of data) {
        let king = kingdomData.kingdom;
        let generalVal = kingdomData.general;
        let armyVal = +kingdomData.army;
        if (!kingdoms.hasOwnProperty(king)) {
            kingdoms[king] = {};
            kingdoms[king].kingdomName = king;
            kingdoms[king].wins = 0;
            kingdoms[king].losses = 0;
            kingdoms[king].generals = {};
        }

        if (!kingdoms[king].generals.hasOwnProperty(generalVal)) {
            kingdoms[king].generals[generalVal] = {};
            kingdoms[king].generals[generalVal].army = 0;
        }
        kingdoms[king].generals[generalVal].army += armyVal;
        kingdoms[king].generals[generalVal].wins = 0;
        kingdoms[king].generals[generalVal].losses = 0;
    }

    for (let line of battles) {
        let [attackKing, attackGen, defendKing, defendGen] = line;
        let attackArmy = kingdoms[attackKing].generals[attackGen].army;
        let defendArmy = kingdoms[defendKing].generals[defendGen].army;

        if (attackKing !== defendKing &&
            kingdoms[attackKing].generals.hasOwnProperty(attackGen) &&
            kingdoms[defendKing].generals.hasOwnProperty(defendGen) &&
            attackArmy !== defendArmy) {
            if (attackArmy > defendArmy) {
                processBattle(attackKing, attackGen, attackArmy, defendKing, defendGen, defendArmy);
            } else {
                processBattle(defendKing, defendGen, defendArmy, attackKing, attackGen, attackArmy)
            }
        }
    }

    function processBattle(attackKing, attackGen, attackArmy, defendKing, defendGen, defendArmy) {
        kingdoms[attackKing].generals[attackGen].army = Math.floor(1.1 * attackArmy);
        kingdoms[attackKing].generals[attackGen].wins += 1;
        kingdoms[attackKing].wins += 1;
        kingdoms[defendKing].generals[defendGen].army = Math.max(Math.floor(0.9 * defendArmy), 0);
        kingdoms[defendKing].generals[defendGen].losses += 1;
        kingdoms[defendKing].losses += 1;

    }

    let winningKingdom = Object.values(kingdoms).sort((a, b) => b.wins - a.wins ||
        a.losses - b.losses ||
        a.kingdomName.localeCompare(b.kingdomName))[0];
    let result = [];
    result.push(`Winner: ${winningKingdom.kingdomName}`);

    let sortedGenerals = Object.keys(winningKingdom.generals).sort((a, b) =>
        winningKingdom.generals[b].army - winningKingdom.generals[a].army);

    for (let gen of sortedGenerals) {
        result.push(`/\\general: ${gen}`);
        result.push(`---army: ${winningKingdom.generals[gen]['army']}`);
        result.push(`---wins: ${winningKingdom.generals[gen]['wins']}`);
        result.push(`---losses: ${winningKingdom.generals[gen]['losses']}`);
    }
    console.log(result.join('\n'));
}

solve(
    [{
            kingdom: "Maiden Way",
            general: "Merek",
            army: 5000
        },
        {
            kingdom: "Stonegate",
            general: "Ulric",
            army: 4900
        },
        {
            kingdom: "Stonegate",
            general: "Doran",
            army: 70000
        },
        {
            kingdom: "YorkenShire",
            general: "Quinn",
            army: 0
        },
        {
            kingdom: "YorkenShire",
            general: "Quinn",
            army: 2000
        },
        {
            kingdom: "Maiden Way",
            general: "Berinon",
            army: 100000
        }
    ],
    [
        ["YorkenShire", "Quinn", "Stonegate", "Ulric"],
        ["Stonegate", "Ulric", "Stonegate", "Doran"],
        ["Stonegate", "Doran", "Maiden Way", "Merek"],
        ["Stonegate", "Ulric", "Maiden Way", "Merek"],
        ["Maiden Way", "Berinon", "Stonegate", "Ulric"]
    ]
);