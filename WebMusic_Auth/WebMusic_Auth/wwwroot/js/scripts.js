(function() {
    "use strict";


    // Toggle Left Menu
   jQuery('.menu-list > a').click(function() {
      
      var parent = jQuery(this).parent();
      var sub = parent.find('> ul');
      
      if(!jQuery('body').hasClass('left-side-collapsed')) {
         if(sub.is(':visible')) {
            sub.slideUp(200, function(){
               parent.removeClass('nav-active');
               jQuery('.main-content').css({height: ''});
               mainContentHeightAdjust();
            });
         } else {
            visibleSubMenuClose();
            parent.addClass('nav-active');
            sub.slideDown(200, function(){
                mainContentHeightAdjust();
            });
         }
      }
      return false;
   });

   function visibleSubMenuClose() {
      jQuery('.menu-list').each(function() {
         var t = jQuery(this);
         if(t.hasClass('nav-active')) {
            t.find('> ul').slideUp(200, function(){
               t.removeClass('nav-active');
            });
         }
      });
   }

   function mainContentHeightAdjust() {
      // Adjust main content height
      var docHeight = jQuery(document).height();
      if(docHeight > jQuery('.main-content').height())
         jQuery('.main-content').height(docHeight);
   }

   //  class add mouse hover
   jQuery('.custom-nav > li').hover(function(){
      jQuery(this).addClass('nav-hover');
   }, function(){
      jQuery(this).removeClass('nav-hover');
   });


   // Menu Toggle
   jQuery('.toggle-btn').click(function(){
       $(".left-side").getNiceScroll().hide();
       
       if ($('body').hasClass('left-side-collapsed')) {
           $(".left-side").getNiceScroll().hide();
       }
      var body = jQuery('body');
      var bodyposition = body.css('position');

      if(bodyposition != 'relative') {

         if(!body.hasClass('left-side-collapsed')) {
            body.addClass('left-side-collapsed');
            jQuery('.custom-nav ul').attr('style','');

            jQuery(this).addClass('menu-collapsed');

         } else {
            body.removeClass('left-side-collapsed chat-view');
            jQuery('.custom-nav li.active ul').css({display: 'block'});

            jQuery(this).removeClass('menu-collapsed');

         }
      } else {

         if(body.hasClass('left-side-show'))
            body.removeClass('left-side-show');
         else
            body.addClass('left-side-show');

         mainContentHeightAdjust();
      }

   });
   

   searchform_reposition();

   jQuery(window).resize(function(){

      if(jQuery('body').css('position') == 'relative') {

         jQuery('body').removeClass('left-side-collapsed');

      } else {

         jQuery('body').css({left: '', marginRight: ''});
      }

      searchform_reposition();

   });

   function searchform_reposition() {
      if(jQuery('.searchform').css('position') == 'relative') {
         jQuery('.searchform').insertBefore('.left-side-inner .logged-user');
      } else {
         jQuery('.searchform').insertBefore('.menu-right');
      }
   }
})(jQuery);

      //                // Dropdowns Script
						//$(document).ready(function() {
						//  $(document).on('click', function(ev) {
						//    ev.stopImmediatePropagation();
						//    $(".dropdown-toggle").dropdown("active");
						//  });
						//});
						
	
     
  /************** Search ****************/
		$(function() {
	    var button = $('#loginButton');
	    var box = $('#loginBox');
	    var form = $('#loginForm');
	    button.removeAttr('href');
	    button.mouseup(function(login) {
	        box.toggle();
	        button.toggleClass('active');
	    });
	    form.mouseup(function() { 
	        return false;
	    });
	    $(this).mouseup(function(login) {
	        if(!($(login.target).parent('#loginButton').length > 0)) {
	            button.removeClass('active');
	            box.hide();
	        }
	    });
        });

var isRandom = false;
var isRepeat = false;
var stateShowLyric = false;
var stateExpandPlaylists = false;
var isVolume = $('#volume-sliderbar').val();
var statefavoriteSong = false;
var stateCommentSong = false;
var numberOfComments = 0;
var data;

$(document).ready(function () {
    var myAudio = new Audio('audio/Gio-Van-Hat-Huong-Ly.mp3');
    //event click button play music
    $('#playmusic-btn').click(function () {
        let playButton = $('#playmusic-btn');
        playButton.toggleClass('bi-play-circle bi-pause-circle');
        if ($(this).hasClass("bi-play-circle")) {
            $('#test').text("Pause");
            $('#CD-Song').css("animation-play-state", "paused");
            // $('#CD-Song').addClass("pause-CD");
            myAudio.pause();
        }
        else {
            $('#test').text("Play");
            // $('#CD-Song').removeClass("pause-CD");
            $('#CD-Song').css("animation-play-state", "running");
            myAudio.play();
        }
    });

    //event click button random song
    $('#shuffle-btn').click(function () {
        isRandom = !isRandom;
        if (isRandom) {
            $('#shuffle-i').css("color", "#1c86dd");
        } else {
            $('#shuffle-i').css("color", "white");
        }
    });

    //event click button repeat song
    $('#repeat-btn').click(function () {
        isRepeat = !isRepeat;
        if (isRepeat) {
            $('#repeat-i').css("color", "#1c86dd");
        } else {
            $('#repeat-i').css("color", "white");
        }
    });

    //event click button volume
    $('#volume-btn').click(function () {
        let volumeButton = $('#volume-btn');
        volumeButton.toggleClass('bi-volume-up bi-volume-mute');
        if ($(this).hasClass("bi-volume-mute")) {
            $('#volume-sliderbar').prop("value", 0);
            myAudio.volume = 0;
        } else {
            $('#volume-sliderbar').prop("value", 100);
            myAudio.volume = 1;
        }
    });

    //event click button to show lyrics
    $("#showlyric-btn").click(function () {
        stateShowLyric = !stateShowLyric;
        if (stateShowLyric) {
            $("#show-lyrics").animate({
                height: '100%'
            });
            $('#show-lyrics-svg').css("fill", "#1c86dd");
            $('#show-lyrics').css("background-color", 'url("/images/background-lyrics4.jpg")');

        } else {
            $("#show-lyrics").animate({
                height: '0'
            });
            $('#show-lyrics-svg').css("fill", "#dadada");
            $('#show-lyrics').css("background-color", 'none');
        }

    });

    //event click button to show playlist
    $("#expand_playlists-btn").click(function () {
        stateExpandPlaylists = !stateExpandPlaylists;
        if (stateExpandPlaylists) {
            $("#show-playlist").animate({
                width: '22.2%'
            });
            $('#expand_playlists-i').css("color", "#1c86dd");
        } else {
            $("#show-playlist").animate({
                width: '0'
            });
            $('#expand_playlists-i').css("color", "#dadada");
        }

    });

    //event change slider volume
    $('#volume-sliderbar').on('input', function () {
        let valueOfVolume = $('#volume-sliderbar').val();
        let volumeButton = $('#volume-btn');
        myAudio.volume = valueOfVolume / 100;
        if (valueOfVolume <= 0) {
            volumeButton.removeClass("bi-volume-up").addClass("bi-volume-mute");
            volumeButton.removeClass("bi-volume-down").addClass("bi-volume-mute");
        } else if (valueOfVolume < 50) {
            volumeButton.removeClass("bi-volume-up").addClass("bi-volume-down");
            volumeButton.removeClass("bi-volume-mute").addClass("bi-volume-down");
        } else {
            volumeButton.removeClass("bi-volume-mute").addClass("bi-volume-up");
            volumeButton.removeClass("bi-volume-down").addClass("bi-volume-up");
        }
    });

    //event click button add playlist
    $('#addtoplaylist-btn').click(function () {
        $.ajax({
            type: "get",
            url: "MusicPlayer/GetPlaylists",
            data: "",
            dataType: "json",
            success: function (data) {
                console.log("abc");
                $('#menu-playlist').empty();
                $(data).each(function (key, value) {
                    let appendPlaylists = '<li>' +
                                            '<button data-PId="'+value.pId+'">' +
                                                '<i class="bi bi-music-note-list"></i>' +
                                                '<span>'+value.pName+'</span>' +
                                            '</button>' +
                                           '</li >';
                    $('#menu-playlist').append(appendPlaylists);
                });
                $('.playlist-content').append("<script src='/js/AddToPlaylistScript.js'></script>");
            }
        });
        $('#modal-add_to_playlist').show();
    });
    $('#close-addplaylist').click(function () {
        $('#modal-add_to_playlist').hide();
    });
    $(window).on('click', function (e) {
        if ($(e.target).is('#modal-add_to_playlist')) {
            $('#modal-add_to_playlist').hide();
        }
    });

    

    //set time of song
    var timeOfSong
    myAudio.onloadeddata = function () {
        timeOfSong = Math.floor(myAudio.duration);
        $('#song-time').text(convertNumberToTime(timeOfSong));
    };

    //function convert number second to time
    function convertNumberToTime(numberOfSeconds) {
        let minutes = Math.floor(numberOfSeconds / 60);
        let seconds = numberOfSeconds - minutes * 60;
        if (seconds < 10) {
            seconds = "0" + seconds;
        }
        if (minutes < 10) {
            minutes = "0" + minutes;
        }
        return minutes + ":" + seconds;
    }

    //function convert time to value of input range
    function convertTimeToValueRange(numberOfSeconds) {
        numberOfSeconds = numberOfSeconds * 10;
        numberOfSeconds = Math.floor(numberOfSeconds);
        return (numberOfSeconds / timeOfSong) * 100;
    }
    //update current time of audio and slider time
    myAudio.ontimeupdate = function () {
        let numberOfSeconds = Math.round(myAudio.currentTime);
        let time = convertNumberToTime(numberOfSeconds);
        $('#current-time').text(time);
        $('#time-sliderbar').val(convertTimeToValueRange(myAudio.currentTime));
        console.log($('#time-sliderbar').val());
        if ($('#time-sliderbar').val() == 1000) {
            myAudio.pause();
            $('#playmusic-btn').removeClass("bi-pause-circle").addClass("bi-play-circle");
            if (isRepeat) {
                myAudio.play();
                myAudio.currentTime = 0;
                $('#playmusic-btn').removeClass("bi-play-circle").addClass("bi-pause-circle");
            } else {
                $('#CD-Song').css("animation-play-state", "paused");
            }
        }
    };

    //event on change slider time
    $('#time-sliderbar').on('input', function () {
        let valueOfSlider = $('#time-sliderbar').val();
        let time = (valueOfSlider * timeOfSong) / 1000;
        myAudio.currentTime = time;
    });


    ///////////////////////////////////////////////////////////////////////////////
    function LoadMusic(data) {
        currentSong = 0;
        function changeSongPlay(current) {
            myAudio.pause();
            myAudio.src = data[current]["files"];
            if ($('#playmusic-btn').hasClass("bi-play-circle")) {
                $('#CD-Song').css("animation-play-state", "running");
                $('#playmusic-btn').removeClass("bi-play-circle").addClass("bi-pause-circle");
                myAudio.pause();
            }
            myAudio.play();
            $('#CD-Song').attr("src", data[current]["photo"]);
            $('.media-content h3').text(data[current]["song"]);
            $('.media-content span').text(data[current]["siName"]);
            $('#lyric-content').empty();
            let lyricsSong = '<p style="color: red;">Lời bài hát</p>' +
                '<p>' + data[current]["lyrics"] + '</p>';
            $('#lyric-content').append(lyricsSong);
            $('#media-content').data("MId", data[current]["mId"]);
            
            let MId = $('#media-content').data('MId');
            let hrefSong = "/MusicPlayer/SongDetail?MId=" + MId;
            let hrefSinger = "/MusicPlayer/SongDetail?SiId=" + data[current]["siId"];
            $('#media-content #song-info-a').attr("href", hrefSong);
            $('#media-content #singer-info-a').attr("href", hrefSinger);
            $.ajax({
                type: "get",
                url: "MusicPlayer/GetStatusLoveSong",
                data: {MId: MId},
                success: function (response) {
                    let favoriteSong = $('#favorite-song-i');
                    if (response) {
                        statefavoriteSong = true;
                        favoriteSong.removeClass("bi-heart").addClass("bi-heart-fill");
                    } else {
                        statefavoriteSong = false;
                        favoriteSong.removeClass("bi-heart-fill").addClass("bi-heart");
                    }
                }
            });
        }
        changeSongPlay(currentSong);
        //function set total time of song
        function loadTimeOfSong() {
            myAudio.onloadeddata = function () {
                timeOfSong = Math.floor(myAudio.duration);
                $('#song-time').text(convertNumberToTime(timeOfSong));
            };
        }
        /*currentSong = 0;*/
        $('#list_of_playlist').empty();
        $(data).each(function (key, value) {
            let appendPlaylistDetail = '<div class="song_of_playlist">' +
                '<button class="playsong-playlist">' +
                '<img src="' + value.photo + '" alt="baihat">' +
                '</button>' +
                '<div class="info_song-playlist">' +
                '<span class="song-name-playlist">' + value.song + '</span>' +
                '<span class="singer-name-playlist">' + value.siName + '</span>' +
                '</div>' +
                '</div>';
            $('#list_of_playlist').append(appendPlaylistDetail);
        });
        $('#list_of_song button').click(function () {
            $(".song_of_playlist").removeClass("active-song_of_playlist");
            $(this).closest(".song_of_playlist").addClass("active-song_of_playlist");

        });
        myAudio.ontimeupdate = function () {
            let numberOfSeconds = Math.round(myAudio.currentTime);
            let time = convertNumberToTime(numberOfSeconds);
            $('#current-time').text(time);
            $('#time-sliderbar').val(convertTimeToValueRange(myAudio.currentTime));
            // console.log($('#time-sliderbar').val());
            if ($('#time-sliderbar').val() == 1000) {
                myAudio.pause();
                $('#playmusic-btn').removeClass("bi-pause-circle").addClass("bi-play-circle");
                if (isRepeat) {
                    myAudio.play();
                    myAudio.currentTime = 0;
                    $('#playmusic-btn').removeClass("bi-play-circle").addClass("bi-pause-circle");
                } else {
                    if (isRandom) {
                        currentSong = Math.floor((Math.random() * data.length));
                    } else {
                        if (currentSong >= data.length - 1) {
                            currentSong = 0;
                        } else {
                            currentSong++;
                        }
                    }
                    changeSongPlay(currentSong);
                    loadTimeOfSong();
                }
            }
        };

        //event click button next song
        $('#next-btn').click(function () {
            if (isRandom) {
                currentSong = Math.floor((Math.random() * data.length));
            } else {
                if (currentSong >= data.length - 1) {
                    currentSong = 0;
                } else {
                    currentSong++;
                }
            }
            changeSongPlay(currentSong);
            loadTimeOfSong();
        });

        //event click button previous song
        $('#pre-btn').click(function () {
            if (isRandom) {
                currentSong = Math.floor((Math.random() * data.length));
            } else {
                if (currentSong <= 0) {
                    currentSong = data.length - 1;
                } else {
                    currentSong--;
                }
            }
            changeSongPlay(currentSong);
            loadTimeOfSong();
        });
    }



    //////////////////////
    $('#phat2').click(function () {
        $.ajax({
            type: "post",
            url: "MusicPlayer/GetPlaylistDetail",
            data: { PId: 1002},
            dataType: "json",
            success: function (response) {
                if (data) {
                    data = undefined;
                }
                data = response;
                console.log(data);
                LoadMusic(data);
            }
        });
    });

    ///////////////////////////////////////////////////////////////////////////////
    $('#phat1').click(function () {
        $.ajax({
            type: "post",
            url: "MusicPlayer/GetPlaylistDetail",
            data: { PId: 1004 },
            dataType: "json",
            success: function (response) {
                if (data) {
                    data = undefined;
                }
                data = response;
                console.log(data);
                /*currentSong = 0;*/
                LoadMusic(data);
            }
        });
    });





    //event click on favorite song button
    $('#favorite-song').click(function () {
        let favoriteSong = $('#favorite-song-i');
        statefavoriteSong = !statefavoriteSong;
        let MId = $('#media-content').data('MId');
        if (statefavoriteSong) {
            favoriteSong.removeClass("bi-heart").addClass("bi-heart-fill");
            $.ajax({
                type: "post",
                url: "MusicPlayer/AddLoveSong",
                data: { MId: MId },
                dataType: "",
                success: function (response) {

                }
            });
        } else {
            favoriteSong.removeClass("bi-heart-fill").addClass("bi-heart");
            $.ajax({
                type: "post",
                url: "MusicPlayer/RemoveLoveSong",
                data: { MId: MId },
                dataType: "",
                success: function (response) {

                }
            });
        }
    });

    //event click on comment song button to show comment details of song
    $('#comment-song').click(function () {
        numberOfComments = 0;
        stateCommentSong = !stateCommentSong;
        let commentSong = $('#comment-song-i');
        if (stateCommentSong) {
            $('#model-comment-song').show();
            commentSong.removeClass("bi-chat-dots").addClass("bi-chat-dots-fill");
            var MId = $('#media-content').data('MId');
            $('#comment-content').empty();
            $.ajax({
                type: "get",
                url: "MusicPlayer/GetCommentsSong",
                data: { MId: MId},
                dataType: "json",
                success: function (response) {
                    $(response).each(function (key, value) {
                        let commentSong = '<div class="comment_of_song">' +
                                            '<img src = "'+value.photo+'" alt = "user-image" class="avatar-user-comment">' +
                                            '<div>' +
                                                '<span class="username-comment">'+value.nickName+'</span>' +
                                                '<div class="content-user-comment">'+value.content+'</div>' +
                                            '</div>' +
                                           '</div>';
                        $('#comment-content').append(commentSong);
                        numberOfComments++;
                    });
                    $('#number_of_comments').text(numberOfComments + " Bình luận");
                }
            });
        } else {
            commentSong.removeClass("bi-chat-dots-fill").addClass("bi-chat-dots");
        }
    });
    $('#close-comment').click(function () {
        $('#model-comment-song').hide();
        stateCommentSong = !stateCommentSong;
        $('#comment-song-i').removeClass("bi-chat-dots-fill").addClass("bi-chat-dots");
    });
    $(window).on('click', function (e) {
        if ($(e.target).is('#model-comment-song')) {
            $('#model-comment-song').hide();
            stateCommentSong = !stateCommentSong;
            $('#comment-song-i').removeClass("bi-chat-dots-fill").addClass("bi-chat-dots");
        }
    });


    function AddCommentSong(commentContent) {
        if (commentContent) {
            let appendComment = '<div class="comment_of_song">' +
                '<img src="/images/Avatar-Default.jpg" alt="user-image" class="avatar-user-comment">' +
                '<div>' +
                '<span class="username-comment">Nguyễn Văn C</span>' +
                '<div class="content-user-comment">' + commentContent + '</div>' +
                '</div>' +
                '</div>';
            $('#comment-content').append(appendComment);
            numberOfComments++;
            $('#number_of_comments').text(numberOfComments + " Bình luận");
            $('#input-comment').val('');
            let MId = $('#media-content').data('MId');
            $.ajax({
                type: "post",
                url: "MusicPlayer/AddCommentSong",
                data: { MId: MId, Content: commentContent},
                dataType: "",
                success: function (response) {

                }
            });
        }
    }
    //event enter comments
    $('#submit-comment').click(function () {
        let commentContent = $('#input-comment').val();
        AddCommentSong(commentContent);

    });

    //event press key enter in input
    $('#input-comment').keypress(function (event) {
        var keycode = (event.keyCode ? event.keyCode : event.which);
        if (keycode == '13') {
            let commentContent = $('#input-comment').val();
            AddCommentSong(commentContent);

        }
    });
    //Playlist
    const heartBtnEles = document.querySelectorAll(".song-heart-btn");
    const navLabelEles = document.querySelectorAll(".main-nav__item");
    const navContentEles = document.querySelectorAll(".nav-content");
    const editBtns = document.querySelectorAll(".edit-btn");


    handleFeatureUI();

    function handleFeatureUI() {
        // Handle when click heart button
        heartBtnEles.forEach((item) => {
            item.addEventListener("click", (e) => {
                item.classList.toggle("heart-active");
                const hearIcon = item.querySelector("i");
                hearIcon.classList.toggle("far");
                hearIcon.classList.toggle("fas");
            });
        });

        // Handle tabui
        navLabelEles.forEach((navLabelEle, index) => {
            const navContentEle = navContentEles[index];

            navLabelEle.onclick = function () {
                document.querySelector(".nav-content.active").classList.remove("active");
                document
                    .querySelector(".main-nav__item.active")
                    .classList.remove("active");

                this.classList.add("active");
                navContentEle.classList.add("active");
            };
        });
    }

    let popup = document.querySelector(".popup-wrapper");
    let popupForm = document.querySelector(".popup-form");
    let popupBtn = document.querySelector(".popup-open");
    let popupClose = document.querySelector(".close-btn");
    let popup1 = document.querySelector(".popup-wrapper1");

    popupBtn.addEventListener("click", (e) => {
        e.preventDefault;
        showPopup();
    });

    popupClose.addEventListener("click", (e) => {
        e.preventDefault;
        removePopup();
    });

    popupForm.addEventListener("submit", () => {
        removePopup();
    });

    popup.addEventListener("click", (e) => {
        let target = e.target;
        if (target.classList.contains("popup-wrapper")) {
            removePopup();
        } else return;
    });

    editBtns.forEach((item) => {
        item.addEventListener("click", (e) => {
            e.preventDefault;
            popup1.classList.add("active");
            bodyScroll();
        });
    });

    function showPopup() {
        console.log(popup);
        popup.classList.add("active");
        bodyScroll();
    }

    function removePopup() {
        popup.classList.remove("active");
        bodyScroll();
    }

    function bodyScroll() {
        document.body.classList.toggle("no-scroll");
    }

  

});

	