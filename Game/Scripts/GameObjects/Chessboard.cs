using Engine;
using Engine.Interfaces;
using Engine.UI;
using Engine.Utils;
using SFML.Graphics;
using Sprite = SFML.Graphics.Sprite;
using Texture = SFML.Graphics.Texture;
using Vector2f = SFML.System.Vector2f;

namespace Game.Scripts.GameObjects;

public class Chessboard : GameObject, IDrawable
{
    private Sprite _background = null!;
    private readonly Cell[,] _cells;
    private readonly Canvas _canvas;
    
    public Drawable? Mesh { get; set; }

    public Chessboard() {
        BackgroundInit();
        Mesh = _background;
        
        _cells = new Cell[8, 8];
        _canvas = new Canvas();
        
        CreateCells();
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
    
    private void CreateCells() {
        float offsetCoefficient = 500f / 8f;
        float currentX = offsetCoefficient / 2;
        float currentY = offsetCoefficient / 2;

        for (int i = 0; i < _cells.GetLength(0); i++) {
            for (int j = 0; j < _cells.GetLength(1); j++) {
                TGUI.Vector2f cellPosition = new(currentX, currentY);
                
                Cell newCell = new Cell(_canvas, cellPosition);
                _cells[i, j] = newCell;
                
                currentX += offsetCoefficient;
            }
            
            currentY += offsetCoefficient - 1;
            currentX = offsetCoefficient / 2;
        }
    }
    
    public virtual void Setup() {
        
    }
}