function solve(input) {
    let names = input.split(' ').join(' ').match(/\b_[a-zA-Z]+\b/g).map(e => e.slice(1))
  
    console.log(names.join(','));
    
}
