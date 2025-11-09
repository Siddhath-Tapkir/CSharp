using CalculateArea;

public class question37 : ICalculateArea
{
    private float Width;
    private float Height;

    public question37(float Width = 0.0f, float Height = 0.0f)
    {
        this.Width = Width;
        this.Height = Height;
    }

    public double CalculateArea() => Width * Height;

    public double CalculateArea(float w, float h)
    {
        this.Width = w;
        this.Height = h;

        return (Width * Height);
    }
}