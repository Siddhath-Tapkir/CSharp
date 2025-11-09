// Write a program which accept radius of circle from user and calculate its area. 
// Consider value of PI as 3.14. (Area = PI * Radius * Radius)
using CalculateArea;
internal class question36 : ICalculateArea
{
    private float Radius;
    private float PI;

    public question36(float r)
    {
        this.Radius = r;
        this.PI = 3.14f;
    }

    public double CalculateArea() => PI * Radius * Radius;
}