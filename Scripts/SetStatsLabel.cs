using Godot;
using System;

public partial class SetStatsLabel : Control
{
	public override void _Process(double delta)
	{
		GetNode<RichTextLabel>("PowerplantLabel").Text = $"{Powerplant.Counter} Power plants";
		GetNode<RichTextLabel>("SchoolLabel").Text = $"{School.Counter} Schools";
	}
}
