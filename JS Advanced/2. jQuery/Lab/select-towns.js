function attachEvents() {
    $('#items li').on('click', select)

    function select() {
        if ($(this).attr('data-selected')) {
            $(this).removeAttr('data-selected')
            $(this).css('backgroundColor', '')
        } else {
            $(this).attr('data-selected', true)
            $(this).css('backgroundColor', '#DDD')
        }
    }
    $('#showTownsButton').on('click', () => {
        $('#selectedTowns').text($('#items li[data-selected]').toArray().map(el => el.textContent).join(', '))
    })
}