namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public partial class PartialClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
