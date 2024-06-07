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