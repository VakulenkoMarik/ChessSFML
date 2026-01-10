using Engine.SceneManagement;

namespace Game;

public class Boot
{
    public static void Main(string[] args) {
        new Engine.Game();
        
        SceneLoader.TryAddScene("MainMenu");
        SceneLoader.LoadScene("MainMenu");
    }
}