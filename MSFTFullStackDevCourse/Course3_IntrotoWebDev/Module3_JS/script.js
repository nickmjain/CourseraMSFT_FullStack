console.log("Hello world");
let x = 10;
var y = 5; // should be avoided in modern jacascirp
var city = "New York";
console.log("x = " + x);
if (x >= 5) {
    console.log("x is greater than or equal to 5");
}
console.log("y = " + y);
console.log("x+ y = " + (x+y));
console.log("city = " + city);

console.log("Running an i loop 5 times");
for (let i = 1; i <= 5; i++) {
    console.log("i = " + i);
}

// Practice function
function squareNumber(number) {
    return number * number;
}
console.log("square of 9 = " + squareNumber(9));

function changeColor() {
    alert("You clicked me! This was implemented using a function");
    // Code to change button color in index.html on click
    let button = document.getElementById("buttonSimpleColorChange");
    if (button.style.backgroundColor === "red") {
        button.style.backgroundColor = "blue";
    } else {
        button.style.backgroundColor = "red";
    }
}

let button2 = document.getElementById("buttonEventListener");
button2.addEventListener("click", function () {
    alert('You clicked me! This was implemented using an Event listener');
});

// Button to add text at end of document body
let button3 = document.getElementById("button3");
button3.addEventListener("click", function () {
    let newData = document.createElement("p");
    newData.textContent = "You just added a new paragraph!";
    document.body.appendChild(newData);
});

