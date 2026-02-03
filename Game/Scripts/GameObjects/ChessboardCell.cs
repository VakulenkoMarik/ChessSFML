using Engine.UI;
using TGUI;

namespace Game.Scripts.GameObjects;

public enum ChessboardCellState
{
    Empty,
    Selected,
    Attacking,
    Active,
}

public class ChessboardCell
{
    public Vector2f Coords { get; init; }
    public Piece? Piece { get; set; }
    private Button CellClickable { get; init; }
    
    private readonly Chessboard _parentChessboard;

    public ChessboardCell(Chessboard parent, Canvas canvas, Vector2f coords) {
        _parentChessboard = parent;
        Coords = coords;

        CellClickable = new Button {
            Size = new Vector2f(50, 50),
            Origin = new Vector2f(0.5f, 0.5f),
            Position = coords,
        };
        
        CellClickable.OnClick += (_, _) => NotifyChessboard();
        
        CellClickable.Renderer.BorderColor = Color.Transparent;
        
        canvas.AddWidget(CellClickable, $"Cell_{coords.X}_{coords.Y}");
    }

    private void NotifyChessboard() {
        _parentChessboard.GetMessageFromCell(this);
    }

    public void ChangeTexture(Texture texture) {
        CellClickable.Renderer.Texture = texture;
    }

    public void SetPiece(Piece piece) {
        Piece = piece;
    }
    
    public void ClearPiece() {
        Piece = null;
    }
}