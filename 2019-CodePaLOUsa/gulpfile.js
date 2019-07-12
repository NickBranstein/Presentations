var gulp = require('gulp');
var sass = require('gulp-sass');
var ts = require('gulp-typescript');
var tsProject = ts.createProject('tsconfig.json');
var browserSync = require('browser-sync').create();
var useref = require('gulp-useref');
var uglify = require('gulp-uglify');
var gulpIf = require('gulp-if');
var cssnano = require('gulp-cssnano');
var imagemin = require('gulp-imagemin');
var cache = require('gulp-cache');
var del = require('del');
var sourcemaps = require('gulp-sourcemaps');

gulp.task('sass', function () {
    return gulp.src("app/scss/**/*.scss")
        .pipe(sass())
        .pipe(gulp.dest("app/css"))
        .pipe(browserSync.reload({ stream: true }))
});

function revealCss(cb) {
    gulp.src('node_modules/reveal.js/css/**/*')
        .pipe(gulp.dest('app/reveal/css'))
        .pipe(gulp.dest('dist/reveal/css'));
    cb();
}

function revealJs(cb) {
    gulp.src('node_modules/reveal.js/js/**/*')
        .pipe(gulp.dest('app/reveal/js'))
        .pipe(gulp.dest('dist/reveal/js'));
    cb();
}

function revealLib(cb) {
    gulp.src('node_modules/reveal.js/lib/**/*')
        .pipe(gulp.dest('app/reveal/lib'))
        .pipe(gulp.dest('dist/reveal/lib'));
    cb();
}

function revealPlugin(cb) {
    gulp.src('node_modules/reveal.js/plugin/**/*')
        .pipe(gulp.dest('app/reveal/plugin'))
        .pipe(gulp.dest('dist/reveal/plugin'));
    cb();
}

gulp.task('reveal', function (cb) {
    gulp.parallel(revealCss, revealJs, revealLib, revealPlugin);
    cb();
});

gulp.task('browserSync', function () {
    browserSync.init({
        server: {
            baseDir: "app"
        },
        open: false
    })
});

gulp.task('useref', function () {
    return gulp.src('app/*.html')
        .pipe(useref())
        .pipe(gulpIf('*.js', uglify()))
        .pipe(gulpIf('*.css', cssnano()))
        .pipe(gulp.dest('dist'))
});

gulp.task('images', function () {
    return gulp.src('app/images/**/*.+(png|jpg|gif|svg)')
        .pipe(cache(imagemin()))
        .pipe(gulp.dest('dist/images'))
});

gulp.task('fonts', function () {
    return gulp.src('app/fonts/**/*')
        .pipe(gulp.dest('dist/fonts'))
});

gulp.task('clean:dist', function() {
    return del('dist');
})

gulp.task('cache:clear', function (callback) {
    return cache.clearAll(callback)
});

gulp.task('typescript', function () {
    var tsResult = tsProject.src()
        .pipe(sourcemaps.init())
        .pipe(tsProject());
    return tsResult.js
        .pipe(sourcemaps.write({
            sourceRoot: '/ts',
            includeContent: false
        }))
        .pipe(gulp.dest('app/js'));
});

gulp.task('watch', gulp.series('browserSync', 'sass', 'typescript'), function () {
    gulp.watch('app/scss/**/*.scss', ['sass']);
    gulp.watch('app/ts/**/*.ts', ['typescript']);
    gulp.watch('app/*.html', browserSync.reload);
    gulp.watch('app/js/**/*.js', browserSync.reload);
});

gulp.task('build', function (cb) {
    gulp.series(
        'clean:dist',
        'typescript',
        'sass',
        'reveal',
        gulp.series('useref', 'images', 'fonts'));
    
    cb();
});

gulp.task('default', gulp.series('build', 'watch'));