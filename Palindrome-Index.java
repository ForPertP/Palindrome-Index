import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.function.*;
import java.util.regex.*;
import java.util.stream.*;
import static java.util.stream.Collectors.joining;
import static java.util.stream.Collectors.toList;

class Result {

    /*
     * Complete the 'palindromeIndex' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    static boolean isPalindrome(String s, int l, int r)
    {
        while (l < r)
        {
            if (s.charAt(l++) != s.charAt(r--))
                return false;
        }
        return true;
    }


    public static int palindromeIndex(String s)
    {
        int l = 0;
        int r = s.length() - 1;

        while (l < r && s.charAt(l) == s.charAt(r))
        {
            l++;
            r--;
        }

        if (l >= r)
            return -1;

        if (isPalindrome(s, l + 1, r))
            return l;

        if (isPalindrome(s, l, r - 1))
            return r;

        return -1;
    }
}
