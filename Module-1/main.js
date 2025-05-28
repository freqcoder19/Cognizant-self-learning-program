// ========== 1. JavaScript Basics ==========
console.log("Welcome to the Community Portal");
window.onload = function () {
  alert("Page fully loaded!");
  loadPreference(); // also load saved event type on start
};

// ========== 2. Syntax, Data Types, Operators ==========
const eventName = "Community Meetup";
const eventDate = "2025-07-15";
let availableSeats = 25;

let eventInfo = `${eventName} on ${eventDate}, Seats Available: ${availableSeats}`;
console.log(eventInfo);

// ========== 3. Conditionals, Loops, Error Handling ==========
const events = [
  { name: "Music Fest", date: "2025-07-20", seats: 10 },
  { name: "Old Event", date: "2024-01-01", seats: 0 },
  { name: "Tech Talk", date: "2025-07-22", seats: 5 }
];

function displayEvents() {
  const today = new Date().toISOString().split("T")[0];
  events.forEach(event => {
    if (event.date > today && event.seats > 0) {
      console.log(`Upcoming: ${event.name}`);
    } else {
      console.log(`Skipping: ${event.name}`);
    }
  });
}
try {
  displayEvents();
} catch (e) {
  console.error("Error displaying events", e);
}

// ========== 4. Functions, Scope, Closures ==========
function addEvent(name, date, category) {
  events.push({ name, date, seats: 10, category });
}

function registerUser(eventName) {
  const event = events.find(e => e.name === eventName);
  if (event && event.seats > 0) {
    event.seats--;
    console.log(`Registered for ${event.name}, seats left: ${event.seats}`);
  } else {
    console.warn("Event full or not found");
  }
}

// Closure to track total registrations by category
function registrationTracker(category) {
  let count = 0;
  return function () {
    count++;
    console.log(`Registrations for ${category}: ${count}`);
  };
}
const trackMusic = registrationTracker("Music");

// ========== 5. Objects & Prototypes ==========
function Event(name, date, seats) {
  this.name = name;
  this.date = date;
  this.seats = seats;
}
Event.prototype.checkAvailability = function () {
  return this.seats > 0;
};
const workshop = new Event("Workshop", "2025-07-30", 5);
console.log(Object.entries(workshop));

// ========== 6. Arrays ==========
const allEvents = ["Music", "Workshop", "Volunteer"];
allEvents.push("Tech Talk");
console.log(allEvents.filter(e => e.includes("Music")));
console.log(allEvents.map(e => `Upcoming: ${e}`));

// ========== 7. DOM Manipulation ==========
const registerForm = document.querySelector("form");
const formOutput = document.getElementById("formOutput");

// ========== 8. Event Handling ==========
document.querySelector("form").addEventListener("submit", function (e) {
  e.preventDefault();
  const name = e.target.elements["name"].value;
  const email = e.target.elements["email"].value;
  const eventType = e.target.elements["eventType"].value;
  formOutput.value = `Thanks ${name}, you've registered for ₹${eventType} event!`;
});

document.getElementById("eventType").addEventListener("change", function (e) {
  document.getElementById("fee").textContent = `Fee: ₹${e.target.value}`;
});

document.querySelector("textarea").addEventListener("keydown", function (e) {
  console.log(`Key pressed: ${e.key}`);
});

// ========== 9. Async/Await ==========
async function fetchEvents() {
  try {
    document.getElementById("videoStatus").textContent = "Loading events...";
    const response = await fetch("https://jsonplaceholder.typicode.com/posts");
    const data = await response.json();
    console.log("Fetched mock events", data.slice(0, 3));
    document.getElementById("videoStatus").textContent = "Events loaded!";
  } catch (err) {
    console.error("Failed to fetch events", err);
  }
}
fetchEvents();

// ========== 10. Modern JS ==========
function formatEvent({ name = "TBD", date = "TBD" }) {
  return `${name} on ${date}`;
}
const [first, ...rest] = allEvents;
console.log("First event:", first);
console.log("Cloned:", [...allEvents]);

// ========== 11. Working with Forms ==========
function validateFormInputs(form) {
  const { name, email } = form.elements;
  if (!name.value || !email.value) {
    alert("Name and Email are required!");
    return false;
  }
  return true;
}

// ========== 12. AJAX & Fetch ==========
function simulateRegistration(userData) {
  console.log("Submitting registration:", userData);
  setTimeout(() => {
    console.log("Server: Registration success");
    alert("Registration submitted!");
  }, 2000);
}

registerForm.addEventListener("submit", function (e) {
  e.preventDefault();
  const formData = {
    name: e.target.name.value,
    email: e.target.email.value,
    event: e.target.eventType.value
  };
  if (validateFormInputs(e.target)) {
    simulateRegistration(formData);
  }
});

// ========== 13. Debugging ==========
console.log("Form submission debug...");
console.log("Form data captured:", registerForm.elements);
