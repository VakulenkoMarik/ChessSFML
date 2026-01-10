using SFML.Graphics;
using SFML.Window;

namespace Engine;

public class Game : IDisposable
{
    private readonly RenderWindow _window;
    
    public Game() {
        _window = new RenderWindow(new VideoMode(500, 500), "Game window");
        _window.Closed += (_, _) => _window.Close();
    }

    public void Run() {
        new GameLoop(_window).Run();
    }
    
    public void Dispose() {
        _window.Dispose();
    }
}