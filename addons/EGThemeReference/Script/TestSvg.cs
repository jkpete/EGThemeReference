using Godot;
using System;

public partial class TestSvg : TextureRect
{
    public override void _Ready()
    {
        this.Texture = GenerateTexture();
        //base._Ready();
    }
    public const string svgTest = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><svg width=\"48\" height=\"24\" viewBox=\"0 0 96 48\" fill=\"none\"><path d=\"M72 44C83.0457 44 92 35.0457 92 24C92 12.9543 83.0457 4 72 4L24 4C12.9543 4 4 12.9543 4 24C4 35.0457 12.9543 44 24 44Z\" fill=\"#207EDF\" stroke=\"#207EDF\" stroke-width=\"2\" stroke-linejoin=\"round\"/><circle cx=\"72\" cy=\"24\" r=\"12\" fill=\"#DCDFE6\" stroke=\"#DCDFE6\" stroke-width=\"2\" /></svg>\"";
    public ImageTexture GenerateTexture(){
        Godot.Image image = new Godot.Image();
        image.LoadSvgFromString(svgTest);
        ImageTexture texture = ImageTexture.CreateFromImage(image);
        return texture;
    }
}
