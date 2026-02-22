using Engine.Utils;
using Game.Scripts.GameObjects;
using TGUI;

namespace Game.Scripts;

public static class CellTextureHandler
{
    private static readonly Dictionary<ChessboardCellState, Texture> CellTextures = new();

    static CellTextureHandler() {
        InitTextures();
    }

    private static void InitTextures() {
        CellTextures.Add(ChessboardCellState.Empty,
            new Texture(PathUtils.Get(@"Resources\Cell\CellEmpty.png")));
        
        CellTextures.Add(ChessboardCellState.Active,
            new Texture(PathUtils.Get(@"Resources\Cell\CellActive.png")));
        
        CellTextures.Add(ChessboardCellState.Attacking,
            new Texture(PathUtils.Get(@"Resources\Cell\CellAttack.png")));
        
        CellTextures.Add(ChessboardCellState.Selected,
            new Texture(PathUtils.Get(@"Resources\Cell\CellSelected.png")));
    }

    public static Texture GetTextureByType(ChessboardCellState type) {
        return CellTextures[type];
    }
}