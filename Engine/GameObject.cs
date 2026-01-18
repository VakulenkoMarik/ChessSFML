using Engine.Interfaces;
using Engine.SceneManagement;

namespace Engine;

public class GameObject
{
    protected GameObject() {
        AddObjectToLists();
    }
    
    private void AddObjectToLists() {
        if (SceneLoader.CurrentScene != null) {
            if (this is IUpdatable updatable) { 
                SceneLoader.CurrentScene.AddUpdatableObject(updatable);
            }

            if (this is IDrawable drawable) {
                SceneLoader.CurrentScene.AddDrawableObject(drawable);
            }
        }
    }
}