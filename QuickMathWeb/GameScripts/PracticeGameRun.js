var playing = false;
var score;
var action;
var timeremaining;
var correctAnswer;

document.getElementById("startpractice").onclick = function () {

    //take input of operation
    let operation = document.getElementById("operation");
    //take input of range
    let range1 = document.getElementById("range1");
    //take input of range 2
    let range2 = document.getElementById("range2");
    //disable start, range, range2, and operation fields
    //enable game box and log
    function disable() {
        document.getElementById("operation").disabled = true;
        document.getElementById("range1").disabled = true;
        document.getElementById("range2").disabled = true;
        document.getElementById("gamebox").disabled = false;
        document.getElementById("log").disabled = false;
    }
    function enable() {
        document.getElementById("operation").disabled = false;
        document.getElementById("range1").disabled = false;
        document.getElementById("range2").disabled = false;
        document.getElementById("gamebox").disabled = true;
        document.getElementById("log").disabled = true;
    }
    
    //load in random question within parameters
    
    // user submits answer
    //checks answer right/wrong
    //displays it in log
    //updates display stats
    //updates question
    function nextQuestion(id) {
        id.innerHTML = "Ooops!";
    }
}
function generateQA() {
    var x = getRndInteger(range1,range2);
    var y = getRndInteger(range1, range2);
    correctAnswer = x * y;

    document.getElementById("question").innerHTML = x + "x" + y;
    var correctPosition = 1 + Math.round(3 * Math.random());

    document.getElementById("box" + correctPosition).innerHTML = correctAnswer;//correct answer

    //wrong answers
    var answers = [correctAnswer];

    for (i = 1; i < 5; i++) {
        if (i != correctPosition) {
            var wrongAnswer;
            do {
                wrongAnswer = (1 +
                    Math.round(9 * Math.random())) * (1 +
                        Math.round(9 * Math.random()));//wrong answer

            } while (answers.indexOf(wrongAnswer) > -1)

            document.getElementById("box" + i).innerHTML = wrongAnswer;
            answers.push(wrongAnswer);
        }
    }
}
function getRndInteger(min, max) {
    return Math.floor(Math.random() * (max - min)) + min;
}
function checkAnswer(operation) {
    switch (operattion) {
        case "Addition":
            if (addend1 + addend2 == Convert.ToInt32(AnswerBox.Text))
                return true;
            else
                return false;

        case "Subtraction":
            if (minuend - subtrahend == Convert.ToInt32(AnswerBox.Text))
                return true;
            else
                return false;

        case "Multiplication":
            if (multiplicand * multiplier == Convert.ToInt32(AnswerBox.Text))
                return true;
            else
                return false;
        case "Division":
            if (dividend / divisor == Convert.ToInt32(AnswerBox.Text))
                return true;
            else
                return false;
        case "Squared":
            if ((int)Math.Pow(square, 2) == Convert.ToInt32(AnswerBox.Text))
            return true;
                    else
            return false;
        case "Cubed":

            if ((int)Math.Pow(cube, 3) == Convert.ToInt32(AnswerBox.Text))
            return true;
                    else
            return false;
        case "Square Root":
            if ((int)Math.Sqrt((int)Math.Pow(sqrt, 2)) == Convert.ToInt32(AnswerBox.Text))
            return true;
                    else
            return false;
        case "Cube Root":
            if ((int)Math.Ceiling(Math.Pow(Math.Pow(cbrt, 3), (int)1 / 3)) == Convert.ToInt32(AnswerBox.Text))
            return true;
                    else
            return false;
        default:
            Console.WriteLine("Default case");
            return false;
    }
}