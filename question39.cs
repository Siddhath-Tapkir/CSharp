using toCelcius;
internal class question39 : ItoCelcius
{
    private float _fTemp;

    public question39(float t = 0.0f)
    {
        this._fTemp = t;
    }

    public double toCelcius() => ((this._fTemp - 32) * ((double)5 / 9));
}