


//So there is a function named main
function main() {

  // In this function there is an Array of strings
  const iWishFor = [
    "An original eight track of William Shatner's 'Lucy in the Sky with Diamonds'",
    "The ability to think of interesting wishes on short notice",
    "A washtub of Skittles",
    "World peace, but not the kind of world peace where all the humans are removed from existence",
    "A TV that is NOT internet-capable",
    "The ability to fly, but, like, really fast...not just, like, how fast I can walk, but, like, fast, you know?"
  ];
  
  //A log for the console that states the title
  console.log("My wishes...");
  //A for loop that prints each string in the array 
  for (const wish of iWishFor) {
    console.log(wish);
  }
}

//Invoking the function
main();