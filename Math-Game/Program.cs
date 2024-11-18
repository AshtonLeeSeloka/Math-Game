using Math_Game;

UserInputHelper userInputHelper = new UserInputHelper();
GameEngine engine = new GameEngine();
int difficultySelected = 0;


//The Game should contain 4 Basic Operations
//Division should result in Integers only
//Users SHould be be presented with a menu to choose an operation
//Previous Results should be stored in a list.
//Once program is closed data is cleared
//implement levels of difficulty
//Add a timer to track how long the user takes to finish the game
//Create a Random Game option 



//Getting the PlayerName
Console.WriteLine("What is your name Squire?");
string? PlayerName = Console.ReadLine();

//Implementing the difficulty Levels
while (true) 
{
	Console.WriteLine($"\nBrave {PlayerName}, Would you like to: \n 1) Save the princess. \n 2) Take the castle. \n 3) Fight the Dragon \n ");
	string? GameMode = Console.ReadLine();

	if (engine.GameSelectionValidation(GameMode) == true)
	{
		difficultySelected = userInputHelper.convertUserInputToInt(GameMode);
		break;
	}
	else
	{
		continue;
	}
}

//Presenting Game Selection Menu
while (true) 
{
	Console.WriteLine($"\n Pick Your Poison: \n 1) Save the princess. \n 2) Take the castle. \n 3) Fight the Dragon \n ");
	string? GameMode = Console.ReadLine();

	if (engine.GameSelectionValidation(GameMode) == true)
	{
		difficultySelected = userInputHelper.convertUserInputToInt(GameMode);
		break;
	}
	else
	{
		continue;
	}


}



Console.ReadKey();

