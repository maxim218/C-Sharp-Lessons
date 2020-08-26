"use strict";

const express = require("express");
const app = express();
const port = 5000;
app.listen(port);
console.log("Server port: " + port);

app.get("/my/file", function(request, response) {
    response.sendFile(__dirname + "/" + "hello.txt");
});