let menus = document.querySelectorAll('ul#menu-principal > li');

function route() {
    let href = window.location.href.split('/');
    return href[href.length - 1];
}

function removeAll() {
    menus.forEach(function (elemento) {
        elemento.querySelector('a').classList.remove('active');
    });
}

if (route() == '') {
    removeAll();
    menus[0].querySelector('a').classList.add('active');
} else if (route() == 'about') {
    removeAll();
    menus[1].querySelector('a').classList.add('active');
} else if (route() == 'veiculos') {
    removeAll();
    menus[2].querySelector('a').classList.add('active');
}
else {
    removeAll();
    menus[3].querySelector('a').classList.add('active');
}