using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using SwinGameSDK;

class AIEasyPlayer : AIPlayer
{
	public AIEasyPlayer (BattleShipsGame controller) : base(controller)
	{
		//nothing really needs to go in here. Right?
	}

	/// GenerateCoordinates should generate random shooting coordinates
	protected override void GenerateCoords (ref int row, ref int column)
	{
		do
		{
			SearchCoords(ref row, ref column);
		} while ((row < 0 || column < 0 || row >= EnemyGrid.Height || column >= EnemyGrid.Width || EnemyGrid[row, column] != TileView.Sea));
		//while inside the grid and not a sea tile do the search
	}

	protected override void ProcessShot (int row, int col, AttackResult result)
	{
		//I assume nothing goes in here right?
	}

	/// SearchCoords will randomly generate shots within the grid as long as its not hit that tile already
	private void SearchCoords(ref int row, ref int column)
	{
		row = _Random.Next(0, EnemyGrid.Height);
		column = _Random.Next(0, EnemyGrid.Width);
	}
}