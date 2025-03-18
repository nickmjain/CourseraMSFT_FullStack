document.addEventListener('DOMContentLoaded', (event) => {
    const button = document.querySelector('button');

    button.onauxclick = function (event) {
        event.preventDefault();
        alert('Button clicked!');
    };
});
