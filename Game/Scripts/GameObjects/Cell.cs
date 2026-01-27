using Engine.SceneManagement;
using Engine.UI;
using TGUI;

namespace Game.Scripts.GameObjects;

public class Cell
{
    public Vector2f Coords { get; init; }
    public bool IsFilled { get; set; } = false;
    public Piece? Piece { get; set; } = null;
    public Button CellClickable { get; init; }

    public Cell(Canvas canvas, Vector2f coords) {
        Coords = coords;

        CellClickable = new Button {
            Size = new Vector2f(50, 50),
            Origin = new Vector2f(0.5f, 0.5f),
            Position = coords
        };
        
        canvas.AddWidget(CellClickable, $"Cell_{coords.X}_{coords.Y}");
    }

    public void SetPiece(Piece piece) {
        Piece = piece;
        IsFilled = true;
    }
    
    public void ClearPiece() {
        Piece = null;
        IsFilled = false;
    }
}