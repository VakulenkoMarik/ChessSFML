using Engine.Interfaces;
using SFML.Graphics;

namespace Engine.SceneManagement;

public class Scene(string name, IInitialSceneScript sceneScript, RenderWindow window)
{
    public string Name { get; init; } = name;
    private readonly GameLoop _gameLoop = new(window);
    
    private bool _isInitialized;

    public void Start() {
        if (!_isInitialized) {
            sceneScript.Init();
            _isInitialized = true;
        }
        
        sceneScript.Start();
        _gameLoop.Run();
    }

    public void Stop() {
        _gameLoop.Stop();
    }
}