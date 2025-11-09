using toMeter;

internal class question38 : ItoMeter
{
    private long _KM;

    public question38(long KM = 0)
    {
        this._KM = KM;
    }

    public long toMeter() => this._KM * 1000;

    public long toMeter(int KM) => KM * 1000;
}