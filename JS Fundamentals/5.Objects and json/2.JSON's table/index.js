function solve(input) {
    let html = '<table>\n'

    for (let obj of input) {
        let person = JSON.parse(obj)

        let name = person.name
        let position = person.position
        let salary = Number(person.salary)

        html += '\t<tr>\n'
        html += `\t\t<td>${htmlEscape(name)}</td>
    \t\t<td>${htmlEscape(position)}</td>
    \t\t<td>${salary}</td>\n`
    html += '\t</tr>\n'
    }
    html += '</table>'

    console.log(html);

    function htmlEscape(text) {
        let map = {
            '"': '&quot;',
            '&': '&amp;',
            "'": '&#39;',
            '<': '&lt;',
            '>': '&gt;'
        }
        return text.replace(/[\"&'<>]/g, ch => map[ch])
    }
    
}

