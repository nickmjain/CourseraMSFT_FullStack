//This code is to demonstrate how to do async coding in JS
function fetchDatawithPromise() {
    return new Promise((resolve, reject) => {
        const xhr = new XMLHttpRequest();
        xhr.open('GET', 'https://jsonplaceholder.typicode.com/users', true);
        xhr.onload = function () {
            if (xhr.status === 200) {
                resolve(JSON.parse(xhr.responseText));
            } else {
                reject('Error in fetching data');
            }
        }
        xhr.send();
    });
}

// test the callback function
fetchDatawithPromise()
    .then(data => console.log(data))
    .catch(error => console.error(error)); 


// async/await implementation of the above
async function fetchDatawithAsync() {
    try {
        const response = await fetch('https://jsonplaceholder.typicode.com/users');
        const data = await response.json();
        console.log(data);
    } catch (error) {
        console.error("Error in fetching data", error);
    }
}
fetchDatawithAsync();