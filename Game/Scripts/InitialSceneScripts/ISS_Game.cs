using Engine.Interfaces;
using Engine.SceneManagement;
using Game.Scripts.GameObjects;

namespace Game.Scripts.InitialSceneScripts;

public class ISS_Game : IInitialSceneScript
{
    private Chessboard _chessboard;
    private bool _isEndGame;
    
    public void Start() {
        new CellTextureHandler();
        _chessboard = new();
        _chessboard.Setup();

        //SceneLoader.Window.Closed += StopGame;

        //RunGame();
    }

    private void RunGame() {
        while (!_isEndGame) {
            
        }
        
        OnEndGame();
    }

    private void OnEndGame() {
        SceneLoader.Window.Closed -= StopGame;
    }
    
    public void StopGame() {
        _isEndGame = true;
    }
    
    private void StopGame(object? sender, EventArgs e) {
        StopGame();
    }
}
