using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Uc1
{
	class CreateBoard
	{
		public void creatBoard()
		{
			char[] board = new char[10];
			for (int i = 1; i < 10; i++)
			{
				board[i] = ' ';
			}
		}
	}
}
