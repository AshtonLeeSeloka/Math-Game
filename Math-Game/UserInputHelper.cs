using Math_Game.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game
{
	internal class UserInputHelper
	{
		/// <summary>
		/// Converts userInput 
		/// </summary>
		/// <param name="menuSize">The required menu size</param>
		/// <param name="userSelection">The string to be tested</param>
		/// <returns>Returns the succesfully converted value or return zero if unsuccesful</returns>
		public int convertUserInputToMenuItem (int menuSize,string? userSelection)
		{
			int listItem;
			bool isGameSelected = int.TryParse(userSelection, out listItem);
			if (isGameSelected == true)
			{
				if (listItem > 0 && listItem <= menuSize)
				{
					return listItem;
				}
				return 0;
			}
			return 0;
		}



		public int convertUserInputToInt(string userSelection)
		{
			int listItem = int.Parse(userSelection);
			return listItem;

		}
	}
}
