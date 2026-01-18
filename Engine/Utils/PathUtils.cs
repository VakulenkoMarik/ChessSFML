namespace Engine.Utils;

public static class PathUtils
{
    private static string _gameRoot = AppContext.BaseDirectory;

    public static void SetGameRoot(string path) {
        _gameRoot = path;
    }

    public static string Get(string path) {
        return Path.Combine(_gameRoot, path);
    }
}