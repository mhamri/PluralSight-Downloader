
var result = {};
var item = 0;
var courses;
var bar = $(".courseProgressBarModuleContainer");

var barItem = 0;
var barMax = bar.length;
var barName = '';
var courseName = '';
var courseAdd = '';
var jsz = '';


barMax = bar.length;

function readTitle() {

    if (barItem < barMax) {
        var $bar = $(bar[barItem]);
        barName = (barItem + 1) + '-' + $bar.attr('title');
        barName = barName.replace('(Click to navigate)', '').trim();
        result[barName] = {};

        $bar.trigger('click');
        courses = $("div#carousel>div");
        readCourses();
    } else {
        jsz = JSON.stringify(result);


    }

}



function readCourses() {

    if (item < courses.length) {

        var topic = $(courses[item]).children();
        var topicDesc = ((topic[0]).innerHTML).replace('\n', '').trim();
        var topicDur = ((topic[1]).innerHTML).replace('\n', '').trim();
        var topicFull = (barItem + 1) + '-' + (item + 1) + '- ' + topicDesc + ' ' + topicDur;
        courseName = topicFull;
        $(courses[item]).trigger('click');

        setTimeout(readVideLink, decideWaitTime(topicDur));
    } else {
        barItem = barItem + 1;
        item = 0;
        courseName = '';
        courseAdd = '';
        readTitle();
    }

}

function decideWaitTime( duration) {
    var timeArray = duration.split(':');
    var min = timeArray[0] * 60;
    var sec = timeArray[1] * 1 ;
    var totalSec = min + sec;
    var totalMiliSec = totalSec * 1000;
    console.log(totalMiliSec);
    var minRange = 60000;
    var maxRange = totalMiliSec/2 ;
    var waitTime = (Math.random() * (maxRange - minRange)) + minRange;
    console.log(waitTime);
    return Math.round(waitTime);

}



function readVideLink() {

    var add = $("#html5Player>video").attr('src');
    result[barName][courseName] = add;
    item = item + 1;
    readCourses();
}

readTitle();

jsz;



