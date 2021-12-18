const $circle = document.getElementById("circle");
var [shrink, growth] = [1, 5];

var interval = setInterval(() => {reSizeradius(-shrink)},1000);

$circle.addEventListener("click", e => {
    //interval;
    shrink += 0.3;
    reSizeradius(growth);
});

function getRadius(){
    return window.getComputedStyle($circle).width;
};

function reSizeradius(pixels){
    let newRadius = parseInt(getRadius()) + pixels;
    $circle.style.width = `${newRadius}px`;
    $circle.style.height = `${newRadius}px`;
};

var gameOver = setInterval(() => {
    if(parseFloat(getRadius()) < 20 || parseFloat(getRadius()) >= 500){
        window.alert('Game Over!');
        location.reload();
    }
}, 300)
