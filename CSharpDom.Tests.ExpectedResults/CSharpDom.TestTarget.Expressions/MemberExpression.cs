using System;

namespace CSharpDom.TestTarget.Expressions
{
    public sealed class MemberExpression
    {
        public string TestMember(Type type)
        {
            return type.FullName;
        }
    }
}
