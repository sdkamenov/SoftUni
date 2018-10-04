function solve(input) {
    let [x1, y1, x2, y2] = input.map(Number);

    let point1 = {
        x: x1,
        y: y1
    };
    let point2 = {
        x: x2,
        y: y2
    };
    let point0 = {
        x: 0,
        y: 0
    };
    checkDistanceValidity(point1, point0);
    checkDistanceValidity(point2, point0);
    checkDistanceValidity(point1, point2);

    function checkDistanceValidity(a, b) {
        let distance = Math.sqrt(Math.pow(a.x - b.x, 2) + Math.pow(a.y - b.y, 2));
        let isValid = distance == Math.round(distance);
        let validation = isValid ? 'valid' : 'invalid';
        let result = `{${a.x}, ${a.y}} to {${b.x}, ${b.y}} is ${validation}`;
        console.log(result);
    }
}