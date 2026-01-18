using Engine.Interfaces;
using SFML.Graphics;

namespace Engine.SceneManagement;

public static class SceneLoader
{
    private static readonly Dictionary<string, Scene> Scenes = new();
    private static Scene? _currentScene;
    
    public static Scene? CurrentScene => _currentScene;
    
    private static RenderWindow _window = null!;
    
    public static void Init(RenderWindow window) {
        _window = window;
    }

    public static bool TryAddScene(string sceneName, IInitialSceneScript sceneScript) {
        Scene scene = new(sceneName, sceneScript, _window);
        return Scenes.TryAdd(sceneName, scene);
    }
    
    public static bool LoadScene(Scene targetScene) {
        return LoadScene(targetScene.Name);
    }
    
    public static bool LoadScene(string sceneName) {
        if (Scenes.TryGetValue(sceneName, out var scene)) {
            StartNewScene(scene);
            return true;
        }
        
        return false;
    }
    
    private static void StartNewScene(Scene newScene) {
        _currentScene?.Stop();
        _currentScene = newScene;
        _currentScene.Start();
    }
}