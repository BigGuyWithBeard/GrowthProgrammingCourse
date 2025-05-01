// Challenge 6:
// Create a variable called time, a variable called placeOfWork and a variable called townOfHome.
// Create an if statement that logs to the console where someone is at times of the day.
// E.g. if the time is 7 1'm at home, at 8 1'm commuting, at 9 1'm at work.

var time = 18;
var placeOfWork = "office";
var townOfHome = "bolton";

if (time < 8) {
  console.log("I'm at home in " + townOfHome);
} else if (time < 9) {
  console.log("I'm commuting to " + placeOfWork);
} else if (time < 17) {
  console.log("I'm at work in " + placeOfWork);
} else if (time < 18) {
  console.log("I'm commuting home from " + placeOfWork);
} else {
  console.log("I'm at home in " + townOfHome);
}
