class AccessModifier
{
    internal int x = 90;
    float y = 234.5f;

    private void DoSomething()
    {

    }
    internal void DoAnotherThing()
    {
        DoSomething();
    }
    public void DoYetAnotherThing()
    {
        DoSomething();
    }
}