$.validator.setDefaults({
    highlight: function (element) {
        $(element).closest('div.mb-3')
            .find('input,label,select,textarea')
            .addClass('is-invalid');
    },
    unhighlight: function (element) {
        $(element).closest('div.mb-3')
            .find('input,label,select,textarea')
            .removeClass('is-invalid');
    }
})