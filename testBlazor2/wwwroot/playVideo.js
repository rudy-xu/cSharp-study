window.playVideo = function (videoUrl) {
    var video = document.getElementById('video');
    if(video != null){
        var source = document.getElementById('videoSource');
        if(source != null){
            source.src = videoUrl;
            video.load();
            video.play();
        }
    }
}