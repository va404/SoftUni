function aggregate(arr) {

    console.log('Sum = ' + arr.reduce((a, b) => a + b))
    console.log('Min = ' + Math.min(...arr))
    console.log('Max = ' + Math.min(...arr))
    console.log('Product = ' + arr.reduce((a, b) => a * b))
    console.log('Join = ' + arr.reduce((a, b) => '' + a + b))
}

aggregate([2,3,10,5])