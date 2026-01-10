using SFML.Graphics;

namespace Engine;

internal class GameLoop(RenderWindow window)
{
    private bool _isStop = false;
    
    public void Run() {
        while (IsGameLoopRunning())
        {
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
    }
    
    private void Render() {
        window.Clear(Color.Black);
        window.Display();
    }

    private bool IsGameLoopRunning() {
        return window.IsOpen && !_isStop;
    }
}