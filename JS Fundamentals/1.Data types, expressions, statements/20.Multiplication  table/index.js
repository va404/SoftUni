function solve(num) {
    let html = '<table border="1">\n'
    html += '\t<tr><th>x</th>'

    for (let i = 1; i <= num; i++) {
        html += `<th>${i}</th>`
    }
    html += '</tr>\n'

    for (let i = 1; i <= num; i++) {
        html += `\t<tr><th>${i}</th>`

        for (let j = 1; j<= num; j++) {
            html += `<td>${i * j}</td>`
        }
        html += '</tr>\n'
    }
    html += '</table>\n'

    console.log(html);
    
}


