let upVote = function (postId) {
    let _data = {
        id:postId
    }
    
    $.ajax({
        url: "/vote/up",
        data: JSON.stringify(_data),
        contentType:"application/json",
        type:"POST",
        dataType: "html",
        success: (newHtml) => {
            $("#voteContainer-" + postId).html(newHtml);
        }

    })
}

let downVote = (postId) => {
    $.ajax({
        url: "/vote/down",
        data: JSON.stringify({ id: postId }),
        contentType: "application/json",
        type: "POST",
        dataType: "html",
        success: (newHtml) => {
            $("#voteContainer-" + postId).html(newHtml);
        }
    })
}

$(document).ready(() => {

    console.log("ready...");
    //upVote();
    $(".vote-button").on("click", function () {
        //!$(this).hasClass('ButtonClicked') ? addClass('ButtonClicked') : '';
        //!$("button").removeClass("active");
        $(this).addClass("active");
    });
});


