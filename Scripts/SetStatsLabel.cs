using Godot;
using System;

public partial class SetStatsLabel : Control
{
	public override void _Process(double delta)
	{
		GetNode<RichTextLabel>("PowerplantLabel").Text = $"Energy score: {StatsManager.Power}";
		GetNode<RichTextLabel>("SchoolLabel").Text = $"Education score: {StatsManager.Education}";
	}
}
