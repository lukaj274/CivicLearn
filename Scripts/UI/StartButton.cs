using Godot;
using System;

public partial class StartButton : TextureButton
{
	[Export] public PackedScene MainScene { get; set; }
	[Export] public AudioStreamPlayer2D SoundPlayer { get; set; }

	public void OnStartButtonPressed()
	{
		SoundPlayer.Play();
		GetTree().ChangeSceneToPacked(MainScene);
	}
}
