function main() {
  const insults = [
    "You look like what morning breath smells like.",
    "If you tried to give me cpr I would probably throw myself back under water",
    "I am not a fan of you",
    "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
    "I'd rather walk than be on the same plane as you",
    "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
    "Do you have to be so...like that?"
  ];

  //a while loop that checked that it would run until three had been placed into a new array and a conditional that asked if the random number generated already matched a one in the new array and if not it would push to the new array. I then created a for loop that with through the indexes and matched one of the random numbers to the insults array.
  const indexes = [];
  while (indexes.length < 3) {
    const randomNum = getRandomInt(0, insults.length - 1);
    if (!indexes.includes(randomNum)) {
      indexes.push(randomNum);
    }
  }

  for (let i=0; i<indexes.length; i++) {
    const index = indexes[i];
    console.log(insults[index]);
  }
}

// Remember getting a random integer in C# is different
function getRandomInt(min, max) {
  min = Math.ceil(min);
  max = Math.floor(max);
  return Math.floor(Math.random() * (max - min + 1)) + min;
}

main();