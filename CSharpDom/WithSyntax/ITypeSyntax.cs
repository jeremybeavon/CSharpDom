using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface ITypeSyntax : IBasicTypeSyntax,
        IHasFields<IFieldSyntax>,
        IHasConstructors<IConstructorSyntax>,
        IHasEventProperties<IEventPropertySyntax>,
        IHasOperatorOverloads<IOperatorOverloadSyntax>,
        IHasConversionOperators<IConversionOperatorSyntax>,
        IHasClasses<INestedClassSyntax>,
        IHasDelegates<INestedDelegateSyntax>,
        IHasEnums<INestedEnumSyntax>,
        IHasInterfaces<INestedInterfaceSyntax>,
        IHasStructs<INestedStructSyntax>
    {
    }
}
