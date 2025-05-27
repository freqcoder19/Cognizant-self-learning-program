using System;

class AccessDemo
{
    public string PublicMessage = "This is public.";
    private string PrivateMessage = "This is private.";
    protected string ProtectedMessage = "This is protected.";

    public void ShowMessages()
    {
        Console.WriteLine(PublicMessage);
        Console.WriteLine(PrivateMessage);
        Console.WriteLine(ProtectedMessage);
    }
}

class DerivedAccess : AccessDemo
{
    public void DisplayFromDerived()
    {
        Console.WriteLine(PublicMessage);
        Console.WriteLine(ProtectedMessage);
    }
}

class NonDerivedAccess
{
    public void DisplayFromNonDerived()
    {
        AccessDemo obj = new AccessDemo();
        Console.WriteLine(obj.PublicMessage);
    }
}

class Program
{
    static void Main()
    {
        AccessDemo baseObj = new AccessDemo();
        baseObj.ShowMessages();

        DerivedAccess derivedObj = new DerivedAccess();
        derivedObj.DisplayFromDerived();

        NonDerivedAccess nonDerivedObj = new NonDerivedAccess();
        nonDerivedObj.DisplayFromNonDerived();
    }
}
