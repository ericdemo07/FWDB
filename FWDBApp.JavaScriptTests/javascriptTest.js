var supertest = require("supertest");
var should = require("should");

var server = supertest.agent("http://localhost:65247");

describe("javascript test", function () {
    it("should pass if output static path returns", function (done) {
        server
        .get("/#/Default/Static")
        .expect("Content-type", /json/)
        .expect(200) // THis is HTTP response
        .end(function (err, res)
        {
            res.status.should.equal(200);
            done();
        });
    });

    it("should pass if output ajax path returns", function (done) {
        server
        .get("/#/Default/Ajax")
        .expect("Content-type", /json/)
        .expect(200) // THis is HTTP response
        .end(function (err, res) {
            res.status.should.equal(200);
            done();
        });
    });
});