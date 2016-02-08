using CSharpDom.Reflection.Internal.Hiding;

namespace CSharpDom.Reflection.Internal
{
    internal interface IInternalTypeWithReflection : ITypeWithReflection
    {
        HiddenMembersAnalyzer HiddenMembersAnalyzer { get; }
    }
}
