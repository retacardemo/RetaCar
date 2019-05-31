function LoginModal(url) {
    $.ajax({
        url: url,
        type: 'GET',
        dataType: 'html',
        success: function (htmlData) {
            $('#login-modal').html(htmlData);
            $('#loginform').modal('show');
        },
        error: function () {
            alert('');
        }
    });
}

function RegisterModal(url) {
    $.ajax({
        url: url,
        type: 'GET',
        dataType: 'html',
        success: function (htmlData) {
            $('#login-modal').html(htmlData);
            $('#loginform').modal('show');
        },
        error: function () {
            alert('');
        }
    });
}

function FogetPasswordModal(url) {
    $.ajax({
        url: url,
        type: 'GET',
        dataType: 'html',
        success: function (htmlData) {
            $('#forgot-modal').html(htmlData);
            $('#forgotpassword').modal('show');
        },
        error: function () {
            alert('');
        }
    });
}

function RegisterModal(url) {
    $.ajax({
        url: url,
        type: 'GET',
        dataType: 'html',
        success: function (htmlData) {
            $('#register-modal').html(htmlData);
            $('#signupform').modal('show');
        },
        error: function () {
            alert('');
        }
    });
}


