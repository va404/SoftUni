function solve(input) {
   input =  input.sort((a, b) => {
       if (a.length != b.length) {
           return a.length > b.length
       } else {
           return a.localeCompare(b)
       }
    })
    console.log(input.join('\n'));
    
}

