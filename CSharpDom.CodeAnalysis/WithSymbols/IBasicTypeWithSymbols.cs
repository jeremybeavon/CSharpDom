using CSharpDom.Common;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public interface IBasicTypeWithSymbols :
        IBasicType<IEventWithSymbols, IPropertyWithSymbols, IIndexerWithSymbols, IMethodWithSymbols>
    {
        bool IsNestedType { get; }
    }
}
