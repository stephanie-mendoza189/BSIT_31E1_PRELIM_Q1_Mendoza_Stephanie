namespace TransportChallenge;

public abstract class Vehicle : IDriveable
{
    public virtual string Move()
    {
        return "Moving...";
    }
}
