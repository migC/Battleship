using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using SwinGameSDK;
/// <summary>
/// This easy player is a type of AIPlayer which wil try and destroy the non-AIPlayer ships.
/// <summart>
class AIEasyPlayer : AIPlayer
{
	/// will not target the same ship to destroy immediately
	//private enum AIStates
	//{
	/////removed
	//}
	public AIEasyPlayer (BattleShipsGame controller) : base(controller)
	{
	}

	/// <summary>
	/// GenerateCoordinates should generate random shooting coordinates
	/// </summary>
	/// <param name="row">the generated row</param>
	/// <param name="column">the generated column</param>
	protected override void GenerateCoords (ref int row, ref int column)
	{
		do
		{
		/// will only search for location
			SearchCoords(ref row, ref column);
		} while ((row < 0 || column < 0 || row >= EnemyGrid.Height || column >= EnemyGrid.Width || EnemyGrid[row, column] != TileView.Sea));
		//while inside the grid and not a sea tile do the search
	}


	protected override void ProcessShot (int row, int col, AttackResult result)
	{
	}

	/// <summary>
	/// SearchCoords randomly shoots around the grid as long as its not landed a hit on a ship.
	/// </summary>
	/// <param name="row">the generated row</param>
	/// <param name="column">the generated column</param>
	private void SearchCoords(ref int row, ref int column)
	{
	/// conditions removed
		row = _Random.Next(0, EnemyGrid.Height);
		column = _Random.Next(0, EnemyGrid.Width);
	}
}
