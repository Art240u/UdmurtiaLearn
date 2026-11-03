using Godot;
using System;
using AccountModel;

public partial class GameState : Node
{
	public static GameState Instance { get; private set; } = null!;
    public Account CurrentAccount { get; set; }

	public override void _Ready()
	{
		Instance = this;
		Database.Init();
	} 

	public override void _Process(double delta)
	{
		
	}
}
