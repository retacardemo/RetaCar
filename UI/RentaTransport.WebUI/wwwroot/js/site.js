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
            $('#register-modal').html(htmlData);
            $('#signupform').modal('show');
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

function GoBack() {
    window.history.back();
}

function ChangeLang(lang, url) {
    $.ajax({
        url: url,
        type: 'post',
        data: { lang: lang },
        success: function (res) {
            if (res.IsCompleted)
                location.reload();
            else
                alertify.error(res.Description);
        },
        error: function () {
            alertify.error('error');
        }
    });
}

function OnFailure(error) {
    $(':input[type="submit"]').prop('disabled', false);
    $("#loading").css('display', 'none');
    alert(error);
}

function OnLoading() {
    $(':input[type="submit"]').prop('disabled', true);
    $("#loading").css('display', 'inline-block');
}


