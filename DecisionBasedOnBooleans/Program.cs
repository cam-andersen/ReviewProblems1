//Should you stay or should you go? You cannot decide from the top of your head whether you want to go to the lecture
//or not. You came up with the following criteria.
//If all off the criteria is fulfilled then you will go to the lecture.

//Criteria:
//Lecture topic is interesting.
//At least one of your friends will join or you have problems with the assignment.

//Write a program that prompts you three questions and gives a recommendation.


//Asks the user for input
Console.WriteLine("Is the lecture interesting?");

//Reads the inout from the user
var line = Console.ReadLine();

//This is one of the boolean variables:
bool isLectureInteresting = true;
if (line == "y")
{
    isLectureInteresting = true;
}

//These are the variables and we create them as booleans and we give them values (true)
bool myFriendsJoins = true;
bool haveProblemsWithTheAssignment = true;

//We create the criterias from the Boolean logic (&& and ||)
if (isLectureInteresting && (myFriendsJoins || haveProblemsWithTheAssignment))
    Console.WriteLine("Go from class");
else 
    Console.WriteLine("Stay in class");
    
    