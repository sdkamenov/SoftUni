function solve([x, y, z, x1, y1, z1]) {
    let deltaX = x - x1;
    let deltaY = y - y1;
    let deltaZ = z - z1;
    let distance = Math.sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    console.log(distance);
}
solve([3.5, 0, 1, 0, 2, -1])