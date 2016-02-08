using CSharpDom.Common;

namespace CSharpDom.Search
{
    public sealed class FindNamespaceForClassVisitor : AbstractSearchVisitor<string>
    {
        public FindNamespaceForClassVisitor(IClass @class)
        {
            @class.Accept(this);
        }

        public override void VisitClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>(
            IClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod> @class)
        {
            if (@class.Namespace != null)
            {
                @class.Namespace.Accept(this);
            }
        }

        public override void VisitNamespace<TUsingDirective, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>(
            INamespace<TUsingDirective, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> @namespace)
        {
            Result = @namespace.Name;
        }
    }
}
