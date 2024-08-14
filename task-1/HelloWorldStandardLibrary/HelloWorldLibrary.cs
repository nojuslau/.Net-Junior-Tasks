namespace HelloWorldStandardLibrary;

public static class HelloWorldLibrary
{
    public static string? IsUsername(this string? str)
    {
        str = str != string.Empty ? $"{DateTime.Now.ToLongTimeString()} Hello, {str}" : string.Empty;
        return str;
    }
}
