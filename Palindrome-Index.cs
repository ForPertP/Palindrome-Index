using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


class Result
{

    /*
     * Complete the 'palindromeIndex' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    private static bool IsPalindrome(string s, int l, int r)
    {
        while (l < r)
        {
            if (s[l++] != s[r--])
                return false;
        }
        return true;
    }    

    public static int palindromeIndex(string s)
    {
        int l = 0;
        int r = s.Length - 1;

        while (l < r && s[l] == s[r])
        {
            l++;
            r--;
        }

        if (l >= r)
            return -1;

        if (IsPalindrome(s, l + 1, r))
            return l;

        if (IsPalindrome(s, l, r - 1))
            return r;

        return -1;
    }
}    
}
