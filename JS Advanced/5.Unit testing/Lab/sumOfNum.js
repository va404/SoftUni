function solve(arr) {
    let sum = 0
    for (let num of arr) {
        sum += num

    }
    return sum
}

describe('Sum tests', function () {
    it('should return 3 [1,2]', function () {
        expect(sum([1,2])).to.be.equal(3)
    })
    it('should return 0 []', function () {
        expect(sum([])).to.be.equal(0)
    })
    it('should return 1 [1]', function () {
        expect(sum([1])).to.be.equal(1)
    })
    it('should return 3.15 [-1, 3.15, 1]', function () {
        expect(sum([-1, 3.15, 1])).to.be.equal(3.15)
    })
    it('should return NaN string', function () {
        expect(sum(['test'])).to.be.NaN
    })
})
