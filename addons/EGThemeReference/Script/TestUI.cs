using Godot;
using System;
using System.IO;
public partial class TestUI : Node
{
	public AcceptDialog AcceptDialog { get; set; }
	public ConfirmationDialog ConfirmationDialog { get; set; }
	public FileDialog FileDialog { get; set; }
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		AcceptDialog= this.GetNode<AcceptDialog>("AcceptDialog");
		ConfirmationDialog= this.GetNode<ConfirmationDialog>("ConfirmationDialog");
		FileDialog = this.GetNode<FileDialog>("FileDialog");
	}
	public void Alert(){
		AcceptDialog.Popup();
	}
	public void Confirm(){
		ConfirmationDialog.Popup();
	}
	public void File(){
		FileDialog.Popup();
	}
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
