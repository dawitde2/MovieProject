var fs = require("fs");
var https = require("https");
fs.writeFile(__dirname + "/index.html",
    "<h1> Html is great </h1>",
    function(error) {
        if (error) {
            return console.log(error);
        } else {
            return console.log("Congrats");
        }
    });

var myPhotoLocation = "https://theconsciousjournal.files.wordpress.com/2013/03/haile-selassie-i-p5.jpg"; 

https.get(myPhotoLocation,
    function(response) {
        response.pipe(fs.createWriteStream(__dirname + "/king.jpg"));
    })