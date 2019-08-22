function getNextArticle(article) {
    return function () {
        if (article.length > 0) {
            $('#content').append($(`<article>${article.shift()}</article>`))
        }
    }
}