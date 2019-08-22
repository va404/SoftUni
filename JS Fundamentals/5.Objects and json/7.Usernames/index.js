function solve(input) {

    let usernames = new Set()

    for (let name of input) {
        usernames.add(name)
    }
    let sortedUsenames = [...usernames].sort((a, b) => { return a.length != b.length ? a.length - b.length : a.localeCompare(b) })
    console.log(sortedUsenames.join('\n'))
}