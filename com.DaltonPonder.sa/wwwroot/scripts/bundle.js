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
function getCultureFromBrowser() {
    var defaultCulture = "en";
    var spanishCulture = "es";
    var cultureFromBrowser = (navigator.languages && navigator.languages.length) ? navigator.languages[0] :
        navigator.language || defaultCulture;
    if (cultureFromBrowser
        && cultureFromBrowser.includes(defaultCulture)
        || cultureFromBrowser.includes(spanishCulture)) {
        setHtmlLangAttribute(cultureFromBrowser);
        return cultureFromBrowser;
    }
    else {
        setHtmlLangAttribute(defaultCulture);
        return defaultCulture;
    }
}

function setHtmlLangAttribute(lang) {
    console.log("Before setting lang attribute");
    console.log("HTML Lang: " + document.documentElement.lang);
    console.log("lang param: " + lang);
    document.documentElement.lang = lang;
    console.log("After setting lang attribute");
    console.log("HTML Lang: " + document.documentElement.lang);
    console.log("lang param: " + lang);
}

window.getCultureFromBrowser = getCultureFromBrowser;
window.setHtmlLangAttribute = setHtmlLangAttribute;