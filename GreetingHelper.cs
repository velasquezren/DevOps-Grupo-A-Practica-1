public static class GreetingHelper
{
    public static string BuildGreeting(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return "Hola, estudiante!";
        }

        return $"Hola, {name.Trim()}!";
    }
}
