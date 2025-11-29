using Godot;
using System;

public partial class School : Node2D
{
	public static int Counter = 0;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Counter++;
		StatsManager.Money -= 100;
		StatsManager.Education += 10;
	}
	
	public override string ToString()
	{
		return $"School #{Counter}";
	}
}
