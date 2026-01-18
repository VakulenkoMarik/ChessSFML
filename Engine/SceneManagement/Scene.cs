using Engine.Interfaces;
using SFML.Graphics;

namespace Engine.SceneManagement;

public class Scene(string name, IInitialSceneScript sceneScript, RenderWindow window)
{
    public string Name { get; init; } = name;
    private readonly GameLoop _gameLoop = new(window);
    
    private bool _isInitialized;

    private readonly List<IDrawable> _drawables = new();
    private readonly List<IUpdatable> _updatables = new();

    public void Start() {
        _gameLoop.SetupObjects(_updatables, _drawables);
        
        HandleSceneScript();
        
        _gameLoop.Run();
    }

    private void HandleSceneScript() {
        if (!_isInitialized) {
            sceneScript.Init();
            _isInitialized = true;
        }
        
        sceneScript.Start();
    }

    public void Stop() {
        _gameLoop.Stop();
    }

    public void AddUpdatableObject(IUpdatable updatable) {
        _updatables.Add(updatable);
    }

    public void AddDrawableObject(IDrawable drawable) {
        _drawables.Add(drawable);
    }
}