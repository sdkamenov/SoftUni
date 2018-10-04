function solve(input) {
    input = input.map(Number);

    for (let i = 0; i < input.length; i += 2) {
        let point = {
            x: input[i],
            y: input[i + 1]
        };
        checkTresureLocation(point);
    }

    function checkTresureLocation(point) {
        let tonga = {
            name: 'Tonga',
            xMin: 0,
            xMax: 2,
            yMin: 6,
            yMax: 8
        };
        let tuvalu = {
            name: 'Tuvalu',
            xMin: 1,
            xMax: 3,
            yMin: 1,
            yMax: 3
        };
        let tokelau = {
            name: 'Tokelau',
            xMin: 8,
            xMax: 9,
            yMin: 0,
            yMax: 1
        };
        let samoa = {
            name: 'Samoa',
            xMin: 5,
            xMax: 7,
            yMin: 3,
            yMax: 6
        };
        let cook = {
            name: 'Cook',
            xMin: 4,
            xMax: 9,
            yMin: 7,
            yMax: 8
        };
        let islands = [samoa, tuvalu, tonga, cook, tokelau];
        let foundTresure = false;

        for (let island of islands) {
            if (checkLocation(point, island)) {
                foundTresure = true;
                console.log(island.name);
                break;
            }
        }

        if (!foundTresure) {
            console.log("On the bottom of the ocean");
        }
    }

    function checkLocation(point, island) {
        return point.x >= island.xMin && point.x <= island.xMax &&
            point.y >= island.yMin && point.y <= island.yMax;
    }
}