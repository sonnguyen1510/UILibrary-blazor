window.getElementLocation = function (element) {
    var rect = element.getBoundingClientRect();

    return {
        top: rect.top,
        left: rect.left,
        bottom: rect.bottom,
        right: rect.right,
    };
    
};