using CSharpDom.Mono.Cecil.Internal.Hiding;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal interface IInternalTypeWithMonoCecil : ITypeWithMonoCecil
    {
        HiddenMembersAnalyzer HiddenMembersAnalyzer { get; }
    }
}
