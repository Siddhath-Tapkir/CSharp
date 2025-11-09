using toSquareMeter;

internal class question40 : ItoSquareMeter
{
    private double _sf;

    public question40(double sf = 0.0)
    {
        this._sf = sf;
    }

    public double toSquareMeter() => this._sf * 0.0929;
}