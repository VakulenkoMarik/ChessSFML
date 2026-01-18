using Engine.SceneManagement;
using Game.Scripts.InitialSceneScripts;

namespace Game;

public class Boot
{
    public static void Main(string[] args) {
        new Engine.Game();
        Engine.Utils.PathUtils.SetGameRoot(AppContext.BaseDirectory);
        
        SceneLoader.TryAddScene("MainMenu", new ISS_MainMenu());
        SceneLoader.TryAddScene("Game", new ISS_Game());
        SceneLoader.LoadScene("Game");
    }
}