function solve(inputArr, sortCriteria) {
    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination
            this.price = price
            this.status = status
        }
    }

    let result = []
    for (let line of inputArr) {

        let tokens = line.split('|')
        let tickets = new Ticket(tokens[0], Number(tokens[1]), tokens[2])
        result.push(tickets)
    }

    switch (sortCriteria) {
        case 'destination':
            result = result.sort((a, b) => a.destination.localeCompare(b.destination))
            break
        case 'status':
            result = result.sort((a, b) => a.status.localeCompare(b.status))
            break
        case 'price':
            result = result.sort((a, b) => a.price - b.price)
            break
    }
    return result
}

console.log(solve(['Philadelphia|94.20|available',
        'New York City|95.99|available',
        'New York City|95.99|sold',
        'Boston|126.20|departed'],
    'destination'
));