function initializeTable() {
    $('#createLink').on('click', createCountry)

    function addCountry(country, capital) {
        let row = $('<tr>').append($('<td>').text(country))
            .append($('<td>').text(capital))
            .append($('<td>').append($('<a href="#">[Up]</a>').on('click', moveUp))
                .append($('<a href="#">[Down]</a>').on('click', moveDown))
                .append($('<a href="#">[Delete]</a>').on('click', dlt)))


        row.appendTo($('#countriesTable'))

    }

    addCountry('Bulgaria', 'Sofia')
    addCountry('Germany', 'Berlin')
    addCountry('Russia', 'Moscow')
    stylisationLinks()

    function createCountry() {
        let country = $('#newCountryText').val()

        let capital = $('#newCapitalText').val()

        let row = $('<tr>')
            .append($('<td>').text(country))
            .append($('<td>').text(capital))
            .append($('<td>').append($('<a href="#">[Up]</a>').on('click', moveUp))
                .append($('<a href="#">[Down]</a>').on('click', moveDown))
                .append($('<a href="#">[Delete]</a>').on('click', dlt)))


        row.appendTo($('#countriesTable'))

        $('#newCountryText').val('')

        $('#newCapitalText').val('')

        stylisationLinks()

    }


    function moveUp() {
        let row = $(this).parent().parent()

        row.fadeOut(() => {
            row.prev().before(row)

            row.fadeIn()

            stylisationLinks()
        })

    }

    function moveDown() {
        let row = $(this).parent().parent()

        row.fadeOut(function () {
            row.next().after(row)

            row.fadeIn()

            stylisationLinks()
        })

    }

    function dlt() {
        $(this).parent().parent().fadeOut(function () {
            $(this).remove()
        })

        stylisationLinks()
    }

    function stylisationLinks() {
        $('#countriesTable a').css('display', 'inline')
        $('#countriesTable tr:nth-child(3) td a:contains("Up")').css('display', 'none')
        $('#countriesTable tr:last-child td a:contains("Down")').css('display', 'none')
    }

}