using System;
using System.Text.RegularExpressions;

public static class StringClean
{
    public static string StringClean(string s) => Regex.Replace(s, @"[\d-]", string.Empty);
}