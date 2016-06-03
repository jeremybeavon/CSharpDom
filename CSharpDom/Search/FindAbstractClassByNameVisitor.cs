using CSharpDom.Common;

namespace CSharpDom.Search
{
    public sealed class FindAbstractClassByNameVisitor<T> : AbstractTypeSearchVisitor<T>
        where T : IAbstractClass
    {
        public FindAbstractClassByNameVisitor(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public override void VisitAbstractClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor>(
            IAbstractClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor> @class)
        {
            if (@class.Name == Name)
            {
                Result = (T)@class;
            }
        }

        public override void VisitClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
        {
            VisitChildren(classCollection.AbstractClasses);
        }

        public override void VisitLoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>(
            ILoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> loadedDocument)
        {
            VisitChildren(loadedDocument.Classes, loadedDocument.Namespaces);
        }

        public override void VisitNamespace<TUsingDirective, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>(
            INamespace<TUsingDirective, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> @namespace)
        {
            VisitChildren(@namespace.Classes);
        }
    }
}
