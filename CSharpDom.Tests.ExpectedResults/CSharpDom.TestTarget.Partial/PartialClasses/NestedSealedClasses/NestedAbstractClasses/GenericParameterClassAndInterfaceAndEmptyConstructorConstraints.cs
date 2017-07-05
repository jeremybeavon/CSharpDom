namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedAbstractClasses
{
    public partial class PartialClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public abstract class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
