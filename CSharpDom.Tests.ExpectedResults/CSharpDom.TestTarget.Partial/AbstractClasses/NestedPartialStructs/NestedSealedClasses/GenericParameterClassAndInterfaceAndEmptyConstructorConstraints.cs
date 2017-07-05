namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedSealedPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public sealed class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
