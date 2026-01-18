using Engine.Interfaces;

namespace Game.Scripts.InitialSceneScripts;

public class ISS_Game : IInitialSceneScript
{
    private Chessboard _chessboard;
    
    public void Start() {
        _chessboard = new();
        _chessboard.Setup();
    }
}