function solve(input) {
    let speed = input[0]
    let area = input[1]

    function getLimit() {
        switch(area) {
            case 'motorway':
                return 130
            case 'interstate':
                return 90
            case 'city': 
                return 50
            case 'residential':
                return 20
        }
    }

    function getInfraction(speed, limit) {
        let overSpeed = speed - limit

        if (overSpeed <= 0) {
            return ''
        } else {
            if (overSpeed > 0 && overSpeed <= 20) {
                return 'speeding'
            } else if (overSpeed > 20 && overSpeed <= 40) {
                return 'excessive speeding'
            } else {
                return 'reckless driving'
            }
        }
    }
    let limit = getLimit(area)
    let infraction = getInfraction(speed, limit)
    console.log(infraction);
    
}

