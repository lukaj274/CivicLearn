using Godot;
using System;

namespace CivicLearn2;

public partial class Hud : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}

	public void OnChangeButtonPressed()
	{
		GetParent().GetNode<Cursor>("Cursor").ToggleActive();
		GD.Print("Button pressed");
		ToggleMenu("change");
		GetNode<Control>("Labels").Visible = !GetNode<Control>("Labels").Visible;
		GetNode<Button>("ChangeBuildingButton").Text = Cursor.IsActive ? "Change Selected Building" : "Close";
	}

	public void OnViewButtonPressed()
	{
		// Show the popup and the stats labels inside
		ToggleMenu("stats");
		GD.Print("Button pressed");
	}

	private void ToggleMenu(string whatToShow)
	{
		GetNode<Control>("Popup").Visible = !GetNode<Control>("Popup").Visible;
		
		switch (whatToShow)
		{
			case "change": GetNode<Control>("Popup/Buttons").Visible = !GetNode<Control>("Popup/Buttons").Visible; break;
			case "stats": GetNode<Control>("Popup/StatsLabels").Visible = !GetNode<Control>("Popup/StatsLabels").Visible; break;
			default: throw new Exception($"Unknown what to show: {whatToShow}");
		}
	}

	private void ToggleMenu()
	{
		GetNode<Control>("Popup").Visible = !GetNode<Control>("Popup").Visible;
	}

	public override void _UnhandledInput(InputEvent @event)
	{
		// When escape key is pressed
		if (Input.IsKeyPressed(Key.Escape))
		{
			if (IsActive())
			{
				OnChangeButtonPressed();
			}
		}
	}

	private bool IsActive()
	{
		Control popup = GetNode<Control>("Popup");
		Control labels = GetNode<Control>("Labels");
		if (popup.Visible && labels.Visible) return true;
		return false;
	}
}