using System.Collections.Generic;
using Xunit;

namespace LeetCode.Arrays;

public class UniqueEmailAddress {
    public int NumUniqueEmails(string[] emails) {
        var newEmails = new HashSet<string>();
        foreach(var email in emails){
            var local = email.Split("@");
            var domain = local[0].Split("+");
            var result = domain[0].Replace(".","")+ "@" + local[1];
            newEmails.Add(result);
        }
        
        return newEmails.Count;
        
    }

    [Fact]
    public void Test()
    {
        var input = new[]
        {
            "test.email+alex@leetcode.com", "test.email.leet+alex@code.com"
        };

        var actual = NumUniqueEmails(input);
        
        Assert.Equal(2, actual);
    }
}