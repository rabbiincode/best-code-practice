///15 best coding practice.


///1. Use PascalCasing for class names and method names.
///example

public class ClientActivity
{
    public void ClearStatistics()
    {
        //...
    }
    public void CalculateStatistics()
    {
        //...
    }
}

///2. Use camelCasing for local variables and method arguments.
///example

public class UserLog
{
    public void Add(LogEvent logEvent)
    {
        int itemCount = logEvent.Items.Count;
        // ...
    }
}

///3. Avoid using Abbreviations.
///example

// Correct
UserGroup userGroup;
Assignment employeeAssignment;

// Avoid
UserGroup usrGrp;
Assignment empAssignment;

// Exceptions
CustomerId customerId;
XmlDocument xmlDocument;

///4. Eliminate dead codes i:e codes that are not serving any purpose

///5. Use predefined type names instead of system type names like Int16, Single, UInt64, etc
///example

// Correct
string firstName;
int lastIndex;

// Avoid
String firstName;
Int32 lastIndex;

///6. Your code should be correctly formatted

///7. Prefix interfaces with the letter I.
///example

public interface IShape
{
}

///8. Interface names are noun (phrases) or adjectives.
///example

public interface IGroupable
{
}

///9. Keep your methods short and concise i:e avoid writing long methods.

///10. Methods shouldn’t have too many parameters i.e. more than 2.
///example

//public void SaveHomeAddress(string name, string homeAddress, string country, string email) --wrong
//public void SaveHomeAddress(string name, string homeAddress) --right

///11. vertically align curly brackets.
///example

// Correct
class Program
{
    static void Main(string[] args)
    {
    }
}

///12. Avoid Long and unnecessary commenting

///13.Avoid using meaningless names when naming variables and others.
///example

//string tm; --wrong
//string team; --right

///14. Keep your code organized within folders inside the solution.

///15. Write short methods when developing code. Avoid writing long methods.