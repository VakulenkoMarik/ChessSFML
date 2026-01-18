using Engine;
using Engine.Interfaces;
using Engine.Utils;
using SFML.Graphics;
using SFML.System;

namespace Game.Scripts;

public class Chessboard : GameObject, IDrawable
{
    private Sprite _background = null!;
    public Drawable Mesh { get; set; } = null!;

    public Chessboard() {
        BackgroundInit();
        Mesh = _background;
    }
    
    private void BackgroundInit() {
        _background = new Sprite();
        string path = PathUtils.Get("Resources\\standardChessboard.png");
        
        _background.Texture = new Texture(path);

        _background.Scale = new Vector2f(
            500f / _background.Texture.Size.X,
            500f / _background.Texture.Size.Y
        );

        _background.Origin = new Vector2f(
            _background.Texture.Size.X / 2f,
            _background.Texture.Size.Y / 2f
        );

        _background.Position = new Vector2f(
            500f / 2f,
            500f / 2f
        );
    }
    
    public void Setup() {
        
    }
}