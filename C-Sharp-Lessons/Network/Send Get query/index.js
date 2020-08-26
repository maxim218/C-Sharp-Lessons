"use strict";

const express = require("express");
const app = express();
const port = 5000;
app.listen(port);
console.log("Server port: " + port);

app.get("/my/pyramid", function(request, response) {
    const waitTime = parseInt(Math.random() * 1000 * 10);
    setTimeout(function() {
        let x = request.query.x;
        let s = x;
        let k = s;
        for(let i = 0; i < 2; i++) {
            s += x;
            k = k + "\n" + s;
        }
        response.end(k + "");
    }, waitTime);
});

app.get("/my/count", function(request, response) {
    const waitTime = parseInt(Math.random() * 1000 * 10);
    setTimeout(function() {
        const a = request.query.a;
        const b = request.query.b;
        const s = parseInt(a) + parseInt(b);
        response.end(s + "");
    }, waitTime);
});