function solve([v1, v2, t]) {
    let speed1inM = v1 * 1000 / 3600;
    let speed2inM = v2 * 1000 / 3600;
    let dist1 = speed1inM * t;
    let dist2 = speed2inM * t;
    let delta = Math.abs(dist1 - dist2);
    console.log(delta);
}
solve([0, 60, 3600])