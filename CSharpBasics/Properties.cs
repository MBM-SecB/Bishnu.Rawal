class Person
{
    private int age = 23;
    internal string name = "Ramesh";

    // Auto-implemented property
    public string Name { get; set; }

    // Read-only property
    public string Address { get; }

    // Getter-setter
    public int Age 
    {
        get
        {
            return age;
        } 
        set
        {
            if(value > 20 && value < 30)
            {
                age = value;
            }
        }
    } 
}