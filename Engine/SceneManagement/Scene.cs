using SFML.Graphics;

namespace Engine.SceneManagement;

public class Scene(string name, RenderWindow window)
{
    public string Name { get; init; } = name;
    
    private readonly GameLoop _gameLoop = new(window);

    public void Start() {
        _gameLoop.Run();
    }

    public void Stop() {
        _gameLoop.Stop();
    }
}