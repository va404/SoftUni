function solve(cmd) {
    let thiss = this
    let obj = (() => {
        function upvote() {
            thiss.upvotes++
        }

        function downvote() {
            thiss.downvotes++
        }

        function score() {
            let obfuscated = thiss.upvotes + thiss.downvotes > 50
            let votesAdd = Math.ceil(0.25 * Math.max(thiss.upvotes, thiss.downvotes))
            let rate;
            if (thiss.upvotes / (thiss.upvotes + thiss.downvotes) > 0.66) {
                rate = 'hot'
            } else if ((thiss.upvotes > 100 || thiss.downvotes > 100) && thiss.upvotes >= thiss.downvotes) {
                rate = 'controversial'
            } else if (thiss.downvotes > thiss.upvotes) {
                rate = 'unpopular'
            } else {
                rate = 'new'
            }
            if (thiss.upvotes + thiss.downvotes < 10) {
                rate = 'new'
            }
            if (obfuscated) {
                return [thiss.upvotes + votesAdd, thiss.downvotes + votesAdd, thiss.upvotes - thiss.downvotes, rate]
            } else {
                return [thiss.upvotes, thiss.downvotes, thiss.upvotes - thiss.downvotes, rate]
            }

        }
        return {upvote, downvote, score}
    })()
    return obj[cmd]()
}
solve()