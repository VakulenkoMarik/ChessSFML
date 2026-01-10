using SFML.Graphics;

namespace Engine;

public class GameLoop(RenderWindow window)
{
    public void Run() {
        while (IsGameRunning())
        {
            Input();
            Update();
            Render();
        }
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
    
    private bool IsGameRunning()
        => window.IsOpen;
}