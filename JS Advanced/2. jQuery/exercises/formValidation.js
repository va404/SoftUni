function validate() {
    $('#company').on('change', showHideCompany)

    $('#submit').on('click', function (event) {
        event.preventDefault()
        let userRegex = /^[a-zA-Z0-9]{3,20}$/
        let passRegex = /^\w{5,15}$/
        let emailRegex = /@.*\./
        let companyNymberRegex = /^[1-9]{1}[0-9]{3}$/
        let allValid = true

        if ($('#username').val().match(userRegex)) {
            $('#username').css('border', 'none')
        } else {
            $('#username').css('border-color', '#ff0000')
            allValid = false
        }
        if ($('#password').val().match(passRegex)) {
            $('#password').css('border', 'none')
        } else {
            $('#password').css('border-color', '#ff0000')
            allValid = false
        }
        if ($('#confirm-password').val().match(passRegex) &&
            $('#confirm-password').val().localeCompare($('#password').val()) == 0) {
            $('#confirm-password').css('border', 'none')
        } else {
            $('#confirm-password').css('border-color', '#ff0000')
            allValid = false
        }
        if ($('#email').val().match(emailRegex)) {
            $('#email').css('border', 'none')
        } else {
            $('#email').css('border-color', '#ff0000')
            allValid = false
        }
        if ($('#company').is(':checked')) {
            if ($('#companyNumber').val().match(companyNymberRegex)) {
                $('#companyNumber').css('border', 'none')
            } else {
                $('#companyNumber').css('border', '#ff0000')
                allValid = false
            }
        }
        if (allValid) {
            $('#valid').css('display', 'block')
        }
        else {
            $('#valid').css('display', 'none')
        }

    })

    function showHideCompany() {
        if ($(this).is(':checked')) {
            $('#companyInfo').css('display', 'block')
        } else {
            $('#companyInfo').css('display', 'none')
        }
    }
}
