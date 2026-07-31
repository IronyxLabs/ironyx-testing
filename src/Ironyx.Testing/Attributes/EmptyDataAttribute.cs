using System.Reflection;
using Xunit.Sdk;

namespace Ironyx.Testing
{
    /// <summary>
    /// Inline data for null, empty string and whitespaces
    /// </summary>
    public class EmptyInlineDataAttribute : DataAttribute
    {
        private readonly IEnumerable<object[]> _data = [
            [null!],
            [string.Empty],
            ["       "]
        ];

        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            return _data;
        }
    }
}
