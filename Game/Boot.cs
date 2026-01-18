using Engine.SceneManagement;
using Game.InitialSceneScripts;

namespace Game;

public class Boot
{
    public static void Main(string[] args) {
        new Engine.Game();
        
        SceneLoader.TryAddScene("MainMenu", new ISS_MainMenu());
        SceneLoader.TryAddScene("Game", new ISS_Game());
        SceneLoader.LoadScene("Game");
    }
}