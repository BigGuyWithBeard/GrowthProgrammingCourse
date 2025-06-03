clapA = document.getElementById('clapA');

clap = new Audio('sounds/clap.wav');

clapA.addEventListener('click', function() {

    clapA.classList.add('expanded');
    clap.play();

    setTimeout(function() {
        clapA.classList.remove('expanded');
    }, 200);
});