using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game
{
	public class GameEngine
	{
		UserInputHelper _userInputHelper1 = new UserInputHelper();



		/// <summary>
		/// Checks if a valid input is entered
		/// </summary>
		/// <param name="gameMode">User selected game mode</param>
		/// <returns>Boolean value to determine if user input is correct</returns>
		public bool GameSelectionValidation(string? gameMode) 
		{
			
			if (gameMode == null)
			{
				return false;
			}
			else 
			{

				if (_userInputHelper1.convertUserInputToMenuItem(3, gameMode) == 0)
				{
					Console.WriteLine("\n Enter a valid selection");
					return false;

				}
				else 
				{
					return true;
				
				}
			}
			
		}



	}
}
