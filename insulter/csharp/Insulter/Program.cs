using System;
using System.Collections.Generic;
using System.Linq;


List<string> ArrayOfInsults = new List<string>() {
    "You look like what morning breath smells like.",
    "If you tried to give me cpr I would probably throw myself back under water",
    "I am not a fan of you",
    "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
    "I'd rather walk than be on the same plane as you",
    "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
    "Do you have to be so...like that?"
};


List<int> randomNumbers = new List<int>();
  while (randomNumbers.Count < 3) {
    int randomNum = new Random().Next(0, 6);
    // Console.WriteLine(randomNum);
    if (!randomNumbers.Contains(randomNum)) {
    //  Console.WriteLine(randomNum);
      randomNumbers.Add(randomNum);
    }
  }

for (int i = 0; i < randomNumbers.Count; i++) {
    int InsultIndex = randomNumbers[i];
    Console.WriteLine(ArrayOfInsults[InsultIndex]);
}

// Console.WriteLine(randomNumbers);







// string randomInsult = ArrayOfInsults[randomNum];
// Console.WriteLine(randomInsult);


// int randomNum2 = new Random().Next(0, 6);

// Console.WriteLine(randomNum2);


// string randomInsult2 = ArrayOfInsults[randomNum2];
// Console.WriteLine(randomInsult2);


// int randomNum3 = new Random().Next(0, 6);
// Console.WriteLine(randomNum3);


//     string randomInsult3 = ArrayOfInsults[randomNum3];
// Console.WriteLine(randomInsult3);






// List<int> InsultBox = new List<int>();
// {};

// while (InsultBox.Count < 3) {
//     int randoNum = new Random().Next(0, ArrayOfInsults.Count -1);
//         if (!InsultBox.Contains(randoNum)) {
//             InsultBox.Add(randoNum);
//         }
// }

// for (int i = 0; i < InsultBox.Count; i++) {
//     int InsultIndex = InsultBox[i];
//     Console.WriteLine(ArrayOfInsults[InsultIndex]);
// }