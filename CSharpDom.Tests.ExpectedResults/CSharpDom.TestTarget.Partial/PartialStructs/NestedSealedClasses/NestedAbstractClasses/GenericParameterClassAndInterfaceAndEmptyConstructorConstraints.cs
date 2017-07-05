namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
