function Uniqid() {
    var text = "";
    var possible = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

    for (var i = 0; i < 20; i++)
        text += possible.charAt(Math.floor(Math.random() * possible.length));

    return text;
}


function isUndefinedOrNull(val) {
    if (val == undefined || val == 'null' || val == null) {
        return '';
    } else {
        return val;
    }
}

function replaceAll(txt, replace, withThis) {
    return txt.replace(new RegExp(replace, 'g'), withThis);
}