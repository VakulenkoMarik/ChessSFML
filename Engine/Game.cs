using Engine.SceneManagement;
using SFML.Graphics;
using SFML.Window;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

namespace Engine;

public class Game : IDisposable
{
    private readonly RenderWindow _window;
    
    public Game() {
        _window = new RenderWindow(new VideoMode(500, 500), "Game window");
        _window.Closed += (_, _) => _window.Close();
        
        SceneLoader.Init(_window);
    }
    
    public void Dispose() {
        _window.Dispose();
    }
}