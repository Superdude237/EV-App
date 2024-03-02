using Godot;
using System;

public partial class Main : Node2D
{
	private void _on_button_2_pressed()
	{
		GetNode<Node2D>("Add Car").Visible = true;
		
		
	}
	
	private void _on_button_4_pressed()
	{
		Node2D car = GetNode<Node2D>("Add Car");
		string CarModel = car.GetNode<TextEdit>("TextEdit1").Text;
		string CarAge = car.GetNode<TextEdit>("TextEdit2").Text;
		string CarMileage = car.GetNode<TextEdit>("TextEdit3").Text;
		
		
		GetNode<Node2D>("Car").GetNode<Label>("Label5").Text = CarMileage;
		GetNode<Node2D>("Car").GetNode<Label>("Label3").Text = 600000 - Convert.ToInt32(CarMileage) + " \nMiles Remaining";
		
		
		GetNode<Node2D>("Car").Visible = true;
		GetNode<Button>("Button2").Visible = false;
		GetNode<Node2D>("Add Car").Visible = false;
		GetNode<Button>("Button3").Visible = true;
	}
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}






