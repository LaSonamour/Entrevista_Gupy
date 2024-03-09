function reverter(str) {
    var novaString = "";
    for (var i = str.length - 1; i >= 0; i--) {
        novaString += str[i];
    }
    return novaString;
}

var string;
string = reverter('Daniel');
alert(string);