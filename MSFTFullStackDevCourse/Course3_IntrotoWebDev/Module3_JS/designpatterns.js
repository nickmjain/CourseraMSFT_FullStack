// This file practices design patterns

// module pattern
const myModule = (function () {
    // private variable
    let privateVariable = "I am private";

    // private function
    function privateFcuntion() {
        console.log(privateVariable);
    }

    return {
        //public function
        publicFunction: function () {
            privateFunction();
        }
    };
})();

// observer pattern
// The horn (subject)
class Horn {
    constructor() {
        this.workers = []; // contains list of subscriber workers
    }
    // method to subscribe a worker to the horn
    subscribe(worker) {
        this.workers.push(worker);
    }

    // Method to unsubscriber a worker from the horn
    unsubscribe(worker) {
        this.workers = this.workers.filter(w => w !== worker);
    }

    // Method to notify all workers when the horn blows
    blowHorn() {
        console.log("Horn: time for lunch!");;
        this.workers.forEach(worker => worker.lunchTime());
    }

    // Singleton pattern
    class hornSingleton {
    constructor() {
        if (hornSingleton.instance) {
            return hornSingleton.instance;
        }

        // Initailize with an empty array of workers
        this.workers = [];
        hornSingleton.instance = this; // store the single instance
    }

    // method to subscribe a worker
    subscriber(work) {
        this.workers.push(worker);
    }

    // method to unsubscribe a worker
    unsubscribe(worker) {
        this.workers = this.workers.filter(w => w !== worker);
    }

    // method to notify all workers
    blowHorn() {
        console.log("Horn: time for lunch!");
        this.workers.forEach(worker => worker.lunchTime());
    }
}

// ---------- simpleplaying with JSON----------------

//declare JSON object
const jsonString = [{ "name": "John", "age": 30 }, { "name": "Jane", "age": 25 }]; "}];

// parse json string into an array of objects
const users = JSON.parse(jsonString);

// access proeprties from the parsed JSON
console.log(users[0].name); // John
console.log(users[1].age); // 25
