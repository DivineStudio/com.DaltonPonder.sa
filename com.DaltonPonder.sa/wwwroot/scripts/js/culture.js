function getCultureFromBrowser() {
    return (navigator.languages && navigator.languages.length) ? navigator.languages[0] :
        navigator.language || 'en';
}

window.getCultureFromBrowser = getCultureFromBrowser;