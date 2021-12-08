var $feedbacks = $('#feedbacks');
$(function () {
    $.ajax({
        url: 'https://localhost:7230/feedback',
        method: 'GET',
        success: function (feedbacks) {
            $.each(feedbacks, function(i, feedback) {
                $feedbacks.append('<h3>Name: ' + feedback.Name + ', role: ' + feedback.Role + '</h3>');
            });
        }
    });
});
