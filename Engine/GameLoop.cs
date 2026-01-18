using Engine.Interfaces;
using SFML.Graphics;

namespace Engine;

internal class GameLoop(RenderWindow window)
{
    private bool _isStop = false;

    private List<IUpdatable> _updatables = new();
    private List<IDrawable> _drawables = new();

    public void SetupObjects(List<IUpdatable> updatables, List<IDrawable> drawables) {
        _updatables = updatables;
        _drawables = drawables;
    }
    
    public void Run() {
        while (IsGameLoopRunning()) {
            Input();
            Update();
            Render();
        }
    }
    
    public void Stop() {
        _isStop = true;
    }

    private void Input() {
        window.DispatchEvents();
    }

    private void Update() {
        Time.Update();
        
        foreach (var updatable in _updatables) {
            updatable.Update();
        }
    }
    
    private void Render() {
        window.Clear(Color.Black);
        
        foreach (var drawable in _drawables) {
            window.Draw(drawable.Mesh);
        }
        
        window.Display();
    }

    private bool IsGameLoopRunning() {
        return window.IsOpen && !_isStop;
    }
}