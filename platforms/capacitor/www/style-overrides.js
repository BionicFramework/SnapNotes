var isMobile = {
    Windows: function () {
        return /IEMobile/i.test(navigator.userAgent);
    },
    Android: function () {
        return /Android/i.test(navigator.userAgent);
    },
    iOS: function () {
        return /iPhone|iPad|iPod/i.test(navigator.userAgent);
    }
};

function injectAndroidSpecificStyles(rule) {
    var div = $("<div />", {
        html: '&shy;<style>' + 
            rule + 
            '</style>'
    }).appendTo("body");
}

if (isMobile.Android()) {
    injectStyles('.accept-image { transform: rotate(90deg); }');
}
