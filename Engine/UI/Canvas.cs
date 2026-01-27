using Engine.Interfaces;
using Engine.SceneManagement;
using SFML.Graphics;
using TGUI;

namespace Engine.UI;

public class Canvas : IDrawable
{
    private readonly Gui _gui;

    public Canvas() {
        RenderWindow window = SceneLoader.Window;
        _gui = new (window);
        
        SceneLoader.CurrentScene?.AddDrawableObject(this);
    }

    public void AddWidget(Widget widget, string name)
        => _gui.Add(widget, name);

    public void Draw()
        => _gui.Draw();

    public void Destroy()
        => _gui.RemoveAllWidgets();

    public Drawable? Mesh { get; set; } = null;
}