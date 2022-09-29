try {
    var storTest = window['localStorage'];
    storTest.setItem("", ".");
    storTest.removeItem("");
}
catch (e) { alert("Local Storage Not Available"); }

function RandomId(min, max) {
    return Math.floor(Math.random() * (max - min)) + min;
}

var ls;
ls = localStorage;
var newUser = true;
while (newUser) {
    var newId = RandomId(1, 1000000);
    if (ls.key(newId) == null) {
        newUser = false;
        ls.setItem(newId, "Username")
    }
}
