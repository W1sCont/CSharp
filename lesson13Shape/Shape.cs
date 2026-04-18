namespace lesson13Shape;

public abstract class Shape
{
    public abstract void Show();
    public abstract double Area();
    public abstract void Save();
    public abstract void Load(string? path);
}