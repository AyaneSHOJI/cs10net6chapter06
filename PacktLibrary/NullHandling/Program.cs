using static System.Console;
using System;
using Packt.Shared;

int thisCannotBeNull = 4;
// thisCannotBeNull = null; // compile error 

int? thisCouldBeNull = null;
WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());

thisCouldBeNull = 7;
WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());

// p.250 checking for null
// check that the variable is not null before using it
if (thisCouldBeNull != null)
{
    // access a member of thisCouldBeNull
    // int length = thisCouldBeNull.Length; 
}

string authorName = null;
// the following throws a NullReferenceException
// int x = authorName.Length;
// instead of throwing an exception, null is assigned to y
// int? y = authorName.Length;

// result will be 3 if authorName?.Length is null
int result = authorName?.Length ?? 3;
WriteLine(result);

// p.249 nullable and non-nullable
Address address = new();
address.Building = null;
address.Street = null;
address.City = "London";
address.Region = null;

class Address
{
    public string? Building;
    public string Street;
    public string City;
    public string Region;
}

//public string Street = string.Empty;
//public string City = string.Empty;
//public string Region = string.Empty;

// P.251 checking for null in method parameters
public void Hire(PE)