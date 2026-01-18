using SFML.Graphics;

namespace Engine.Interfaces;

public interface IDrawable
{
    public Drawable Mesh { get; protected set; }
}