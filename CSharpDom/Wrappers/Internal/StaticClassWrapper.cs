using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassWrapper : AbstractWrapper<IStaticClass>
    {
        public StaticClassWrapper(IStaticClass @class)
            : base(@class)
        {
        }

        public override void VisitStaticClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IStaticClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> @class)
        {
            Value = new StaticClass()
            {
                Attributes = @class.Attributes.ToAttributeListUsingWrapper(),
                Classes = new StaticClassNestedClassCollectionWrapper(@class.Classes).Value,
                Delegates = @class.Delegates.ToList(@delegate => new StaticClassNestedDelegateWrapper(@delegate).Value),
                Enums = @class.Enums.ToList(@enum => new StaticClassNestedEnumWrapper(@enum).Value),
                Events = new StaticClassEventCollectionWrapper(@class.Events).Value,
                Fields = new StaticClassFieldCollectionWrapper(@class.Fields).Value,
                GenericParameters = @class.GenericParameters.ToGenericParameterDeclarationListUsingWrapper(),
                Interfaces = new StaticClassNestedInterfaceCollectionWrapper(@class.Interfaces).Value,
                Methods = new StaticClassMethodCollectionWrapper(@class.Methods).Value,
                Name = @class.Name,
                Properties = @class.Properties.ToList(property => new StaticClassPropertyWrapper(property).Value),
                StaticConstructor = new StaticConstructorWrapper(@class.StaticConstructor).Value,
                Structs = new StaticClassNestedStructCollectionWrapper(@class.Structs).Value,
                Visibility = @class.Visibility
            };
            if (Value.StaticConstructor != null)
            {
                Value.StaticConstructor.AttachDeclaringType(@class);
            }
        }
    }
}
