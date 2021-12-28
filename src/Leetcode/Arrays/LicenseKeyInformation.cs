using System.Text;
using Xunit;

namespace LeetCode.Arrays
{
    public class LicenseKeyInformation
    {
        public string LicenseKeyFormatting(string s, int k)
        {
            var S = s.Replace("-", "").ToUpper();
            var sb = new StringBuilder();
            for (int i = 0; i < S.Length; i++)
            {
                if (i != 0 && (S.Length - i) % k == 0)
                {
                    sb.Append('-');
                }
                sb.Append(S[i]);
            }
            return sb.ToString();

        }

        [Theory]
        [InlineData("2-5g-3-J", 2, "2-5G-3J")]
        public void Test(string input, int k, string expected)
        {
            var actual = LicenseKeyFormatting(input, k);
            
            Assert.Equal(expected, actual);

        }
    }
}