using CSharpDom.Common;

namespace CSharpDom.CodeAnalysis.WithSyntax
{
    public interface ITypeSyntax : 
        IBasicTypeSyntax,
        IType<IEventSyntax, IPropertySyntax, IIndexerSyntax, IMethodSyntax, IFieldSyntax, IConstructorSyntax, IEventPropertySyntax, IOperatorOverloadSyntax, IConversionOperatorSyntax, INestedClassSyntax, INestedDelegateSyntax, INestedEnumSyntax, INestedInterfaceSyntax, INestedStructSyntax>
    {
    }
}
