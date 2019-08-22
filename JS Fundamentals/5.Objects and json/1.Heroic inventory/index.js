function solve(input) {
    let heroes = []

    for (let i = 0; i <input.length; i++) {

        let currentItems = []
        let currentHero = input[i].split(' / ')
        let currentName = currentHero[0]
        let currentLvl = Number(currentHero[1])
        if (currentHero.length>2) {
             currentItems = currentHero[2].split(', ')
        }
        let hero = {
            name: currentName,
            level: currentLvl,
            items: currentItems

        }
        heroes.push(hero)

    }
    console.log(JSON.stringify(heroes))
}