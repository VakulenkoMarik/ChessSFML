using Engine.Interfaces;
using Game.Scripts.GameObjects;

namespace Game.Scripts.InitialSceneScripts;

public class ISS_Game : IInitialSceneScript
{
    private Chessboard _chessboard;
    
    public void Start() {
        _chessboard = new();
        _chessboard.Setup();
    }
}