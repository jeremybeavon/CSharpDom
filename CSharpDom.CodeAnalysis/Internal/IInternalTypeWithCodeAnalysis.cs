using CSharpDom.Mono.Cecil.Internal.Hiding;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal interface IInternalTypeWithCodeAnalysis : ITypeWithCodeAnalysis
    {
        HiddenMembersAnalyzer HiddenMembersAnalyzer { get; }
    }
}
