using Engine.Utils;
using Game.Scripts.GameObjects;
using TGUI;

namespace Game.Scripts;

public class CellTextureHandler
{
    public static CellTextureHandler Instance;
    
    private readonly Dictionary<ChessboardCellState, Texture> _cellTextures = new();

    public CellTextureHandler() {
        Instance = this;
        
        InitTextures();
    }

    private void InitTextures() {
        _cellTextures.Add(ChessboardCellState.Empty,
            new Texture(PathUtils.Get(@"Resources\Cell\CellEmpty.png")));
        
        _cellTextures.Add(ChessboardCellState.Active,
            new Texture(PathUtils.Get(@"Resources\Cell\CellActive.png")));
        
        _cellTextures.Add(ChessboardCellState.Attacking,
            new Texture(PathUtils.Get(@"Resources\Cell\CellAttack.png")));
        
        _cellTextures.Add(ChessboardCellState.Selected,
            new Texture(PathUtils.Get(@"Resources\Cell\CellSelected.png")));
    }

    public Texture GetTextureByType(ChessboardCellState type) {
        return _cellTextures[type];
    }
}