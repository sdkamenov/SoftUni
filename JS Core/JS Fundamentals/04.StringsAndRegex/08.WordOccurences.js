function solve(string, word) {
    let reg = new RegExp('\\b' + word + '\\b', 'ig');
    let count = 0;
    let match
    while (match = reg.exec(string)) {
        count++;
    }
    console.log(count);

}
solve('How do you plan on achieving that? How? How can you even think of that?',
    'how'


)