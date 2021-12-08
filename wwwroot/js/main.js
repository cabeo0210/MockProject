var $feedbacks = $("#feedbacks");
$(function () {
  $.ajax({
    url: "https://localhost:7230/feedback/",
    method: "GET",
    dataType: "json",
    success: function (feedbacks) {
      $.each(feedbacks, function (i, feedback) {
        $feedbacks.append(
          // "<h3>Name: " + feedback.name + ", role: " + feedback.role + "</h3>"

          '<div class="testi-item" data-aos="zoom-in"> ' +
            ' <div class="testi-author">' +
            '   <div class="testi-author-name">' +
            "    <h3>" +
            feedback.name +
            "</h3>" +
            "   <span>" +
            feedback.role +
            "</span>" +
            "  </div>" +
            '  <div class="testi-author-img">' +
            '      <img src="img/testimonials/1.jpg" alt="testi author img">' +
            " </div>" +
            "  </div>" +
            " <p>Really good</p>" +
            ' <div class="ratings">' +
            '    <i class="fas fa-star"></i>' +
            '    <i class="fas fa-star"></i>' +
            '    <i class="fas fa-star"></i>' +
            '   <i class="fas fa-star"></i>' +
            '   <i class="fas fa-star"></i>' +
            " </div>" +
            " </div>"
        );
      });
      //   console.log(feedbacks);
    },
  });
});
