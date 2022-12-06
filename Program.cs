// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Prefix!");

Prefix.LCP lcp = new();
string[] strings = {"billboard", "billiards", "billy"};
lcp.LongestCommonPrefix(strings);