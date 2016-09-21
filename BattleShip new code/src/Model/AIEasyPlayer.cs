using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

public class AIEasyPlayer : AIPlayer
{
	public AIEasyPlayer(BattleShipsGame controller) : base(controller)
	{
	}

	protected override void GenerateCoords(ref int row, ref int column)
	{
		do {
			row = _Random.Next(0, EnemyGrid.Height);
			column = _Random.Next(0, EnemyGrid.Width);

		} while ((row < 0 || column < 0 || row >= EnemyGrid.Height || column >= EnemyGrid.Width ||  EnemyGrid[row, column] != TileView.Sea));
	}

	protected override void ProcessShot(int row, int col, AttackResult result)
	{
	}
}