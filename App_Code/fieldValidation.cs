using System;
using System.Collections.Generic;
using System.Web;

using System.Text;
using System.Text.RegularExpressions;

/// <summary>
/// Validation of fields and types for application
/// </summary>
public class fieldValidation
{

    // positive number with decimal allowed
    public static bool isMoney(string text)
    {
        Regex regex = new Regex(@"^[+]?[0-9]*\.?[0-9]+$");
        return regex.IsMatch(text);
    }


    // user input of IP address
    public static bool isMoney(string text)
    {
        Regex regex = new Regex(@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3} (?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
        return regex.IsMatch(text);
    }




    // Match all alphanumeric character and predefined wild characters '@*#.'. Password must be between 6 and 50 characters.
    public static bool isPassword(string text)
    {
        Regex regex = new Regex(@"^([a-zA-Z0-9@*#.]{6,50})$");
        return regex.IsMatch(text);
    }

    // E-mail matches: username@domain.com | u-s_e.r1@s-ub2.domain-name.museum:8080 | user_name@123.123.123.12
    public static bool isEmail(string text)
    {
        Regex regex = new Regex(@"^[\w-]+(\.[\w-]+)*@([a-z0-9-]+(\.[a-z0-9-]+)*?\.[a-z]{2,6}|(\d{1,3}\.){3}\d{1,3})(:\d{4})?$");
        return regex.IsMatch(text);
    }

    // File Name Validator: only allow a-z, A-Z, 0-9, underscores, hyphens, decimals, and spaces.
    public static bool HC_isValidFileName(string text)
    {
        //Regex regex = new Regex(@"^[a-zA-Z0-9_\s-]+$");
        Regex regex = new Regex(@"^([a-zA-Z0-9_\s-.]{3,200})$");
        return regex.IsMatch(text);
    }


}
