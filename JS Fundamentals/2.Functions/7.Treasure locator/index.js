function solve(input) {
    let tuvalu = {
        x1: 1,
        y1: 1,
        x2: 3,
        y2: 3
    }
    let tokelau = {
        x1: 8,
        y1: 0,
        x2: 9,
        y2: 1
    } 
    let samoa = {
        x1: 5,
        y1: 3,
        x2: 7,
        y2: 6
    } 
    let tonga = {
        x1: 0,
        y1: 6,
        x2: 2,
        y2: 8
    } 
    let cook = {
        x1: 4,
        y1: 7,
        x2: 9,
        y2: 8
    } 
    
    for (let i = 0; i < input.length; i+=2) {
      let x1 = Number(input[i])
      let y1 = Number(input[i+1])

      if (x1 >= tuvalu.x1 && x1 <= tuvalu.x2 && y1 >= tuvalu.y1 && y1 <= tuvalu.y2) {
        console.log('Tuvalu');
      } else if (x1 >= tokelau.x1 && x1 <= tokelau.x2 && y1 >= tokelau.y1 && y1 <= tokelau.y2) {
        console.log('Tokelau');
      } else if (x1 >= samoa.x1 && x1 <= samoa.x2 && y1 >= samoa.y1 && y1 <= samoa.y2) {
        console.log('Samoa');
      } else if (x1 >= tonga.x1 && x1 <= tonga.x2 && y1 >= tonga.y1 && y1 <= tonga.y2) {
        console.log('Tonga');
      } else if (x1 >= cook.x1 && x1 <= cook.x2 && y1 >= cook.y1 && y1 <= cook.y2) {
        console.log('Cook');
      } else {
          console.log('On the bottom of the ocean');   
      }   
    }
}
