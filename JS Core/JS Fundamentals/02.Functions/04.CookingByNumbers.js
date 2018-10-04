function solve(input) {
    let number = +input[0];

    let chop = () => number / 2;
    let dice = () => Math.sqrt(number);
    let spice = () => number + 1;
    let bake = () => number * 3;
    let fillet = () => number * 0.80;

    for (let i = 1; i < input.length; i++) {
        switch (input[i]) {
            case 'chop':
                number = chop();
                break;
            case 'dice':
                number = dice();
                break;
            case 'spice':
                number = spice();
                break;
            case 'bake':
                number = bake();
                break;
            case 'fillet':
                number = fillet();
                break;
        }
        console.log(number);
    }
}