const readline = require('readline-sync');
const masterMindLogic = require('./masterMindLogic.js');

class masterMind {
    run() {
        console.log("Hello, welcome to the great game of MasterMind!");
        console.log();
        console.log("Which level do you want to play (1-9)?");

        var level;

        do
        {
            level = readline.questionInt()
        } while (level < 1 || level > 9);

        console.log();
        console.log();

        var upperOption = String.fromCharCode('A'.charCodeAt(0) + level + 2);
        console.log("Great, we will play on level " + level +". This means the options for each position are 'A' - '" + upperOption + "'");
        console.log();
        console.log("I have received the code. It has 4 positions. Please start your quest in guessing it.");

        var codeCorrect = false;
        var round = 1;

        var code = masterMindLogic.receiveCode(level);
        var input;

         do
         {
             console.log("--- Round " + round + " ---");
             console.log("Enter your guess (4 positions): ");
             input = readline.question().toUpperCase();
             console.log("Your guess delivers this result (C=correct input | P=correct position): " + masterMindLogic.GetGuessFeedback(code, input));
             round++;
        } while (input != code);

        console.log();
        console.log("###############################################################");
        console.log("Congratulations, you found the secret code!");
        console.log("It took you " + (round-1) + " rounds.");
        console.log("###############################################################");
    }
}

module.exports = masterMind;