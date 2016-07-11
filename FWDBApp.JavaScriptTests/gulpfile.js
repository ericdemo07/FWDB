var gulp = require('gulp');
var mocha = require('gulp-mocha');
var supertest = require("supertest");
var should = require("should");


gulp.task('mocha', function () {
    return gulp.src(['javaScriptTest.js'], { read: false })
      .pipe(mocha({
          reporter: 'spec'
      }));
});
