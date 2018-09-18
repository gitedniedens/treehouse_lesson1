using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// String Formatting Classes For Use Across Application
/// </summary>
public class stringFormatting
{

    // replace single and double quote, also less than and greater than sign for HTML
	public static string filterInput(string inputString)
	{

        string outputString;


        outputString = inputString.Replace("'", "");
        outputString = outputString.Replace("\"", "");
        outputString = outputString.Replace("<", "");
        outputString = outputString.Replace(">", "");


        return outputString;

	}



}