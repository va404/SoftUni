function solve(input) {
    let xmlText = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" + 
    "<quiz>\n" +
    "   <question>\n"

    for (let i = 0; i < input.length; i+=2) {
        let question = input[i]
        let answer = input[i+1]

        xmlText += "   " + question + "\n" + " \<\/question>\n" + "\<answer>\n" + '      ' + answer + "\n \<\/answer>\n"
        
        if (i < input.length - 2) {
            xmlText += " \<question>\n"
        }

    }
    xmlText    += "\<\/quiz>\n"
    return xmlText
}
console.log(solve(['Who was the forty-second president of USA.?', 'Willian Jefferson Clinton']));
