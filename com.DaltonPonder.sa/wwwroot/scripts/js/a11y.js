function setUpSkipToAboutMe() {
    var skipToAboutMe = document.querySelector('#skipToAboutMe');

    skipToAboutMe.addEventListener('click', function (e) {
        e.preventDefault();
        e.stopPropagation();
        var aboutMe = document.querySelector('#aboutMe');
        var y = aboutMe.getBoundingClientRect().top + window.scrollY - 84;
        window.scrollTo({ top: y, behavior: 'smooth' });
        aboutMe.focus();
    });
}

window.setUpSkipToAboutMe = setUpSkipToAboutMe;