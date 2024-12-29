console.log('test blog')
const blogForm = {
    init: function () {

    },
    save: function (event) {
        event.preventDefault();

        var $form = $('#formBlog');
        var url = $form.attr('action');

        var formData = new FormData($form[0]);

        for (var pair of formData.entries()) {
            console.log(`${pair[0]}: ${pair[1]}`);
        }
    }
}
