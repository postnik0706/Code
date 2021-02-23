public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public (string Name, int Number) GetFruit()
    {
        return (Name: "Apples", Number: 5);
    }
}