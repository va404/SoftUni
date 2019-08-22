(function bookGenerator () {

    let id = 1;
    return function (selector, titleName, authorName, isbn) {

        $(selector).append($('<div>').attr('id', 'book' + id)
            .append($('<p>').addClass('title').text(titleName))
            .append($('<p>').addClass('author').text(authorName))
            .append($('<p>').addClass('isbn').text(isbn))
            .append($('<button>').text('Select').on('click', select))
            .append($('<button>').text('Deselect').on('click', deselect)));

        function select() {
            $(this).parent().css('border', '2px solid blue');
        }

        function deselect() {
            $(this).parent().css('border', '');
        }

        id++;
    }
}());





function domSearch(selector, isCaseSensitive) {
    $(selector).append($('<div>').addClass('add-controls').append($('<label>').text('Enter text: ').append($('<input>')))
        .append($('<div>').addClass('button').text('Add').on('click', addItem)))
    $(selector).append($('<div>').addClass('search-controls').append($('<label>').text('Search:').append($('<input>').on('click', search()))))
    $(selector).append($('<div>').addClass('result-controls').append($('<ul>').addClass('items-list')))

    function addItem() {
        let text = $('.add-controls label input').val()
        $('.items-list').append($('<li>').addClass('list-item').append($('<a>').addClass('button').text('X').on('click', deleteItem)).append($('<strong>').text(text)))
        $('.add-controls label input').val('')
    }

    function deleteItem() {
        $(this).parent().remove()
    }

    function search() {
        let text = $(this).val()
        $('.list-item').each((index, li) => matches(li, text))
    }

    function matches(li, text) {
        $(li).css('display', 'inline-block')
        if (isCaseSensitive) {
            if ($(li).find('strong').text().indexOf(text) == -1) {
                $(li).css('display', 'none')
            }
        } else {
            if ($(li).find('strong').text().toLowerCase().indexOf(text.toLowerCase()) == -1) {
                $(li).css('display', 'none')
            }
        }
    }

}

//

function calendar([day, month, year]) {
    let today = new Date(year, month - 1, day)
    let monthNames = [
        'January', 'February', 'March', 'April',
        'May', 'June', 'July', 'August',
        'September', 'October', 'November', 'December'
    ]
    let captionContent = monthNames[today.getMonth()] + ' ' + today.getFullYear()

    $('#content').append($('<table>').append($('<caption>').text(captionContent)).append($('<tbody>')))
    let daysNum = 0
    let lastDayInMonth = new Date(year, month, 0)
    daysNum += lastDayInMonth.getDate()
    let prevMonthDays = (new Date(year, month - 1, 0)).getDay()
    let nextMonthDays = (7 - new Date(year, month, 0).getDay() % 7) % 7
    daysNum += prevMonthDays + nextMonthDays

    $('tbody').append($('<tr>').append($('<th>').text('Mon')).append($('<th>').text('Tue')).append($('<th>').text('Wed'))
        .append($('<th>').text('Thu')).append($('<th>').text('Fri')).append($('<th>').text('Sat'))
        .append($('<th>').text('Sun')))
    let daysCounter = 0 - prevMonthDays +1

    for (let i = 0; i < daysNum / 7; i++) {
        $('tbody').append($('<tr>'))
        for (let j = 0; j < 7; j++) {
            let crrDay
            if (daysCounter < 1 || daysCounter > lastDayInMonth.getDate()) {
                crrDay = ""
            } else {
                crrDay = daysCounter
            }
            if (crrDay == today.getDate()) {
                $('tbody tr:last-child').append($('<td>').addClass('today').text(crrDay))
            } else {
                $('tbody tr:last-child').append($('<td>').text(crrDay))
            }
            daysCounter++
        }
    }
}