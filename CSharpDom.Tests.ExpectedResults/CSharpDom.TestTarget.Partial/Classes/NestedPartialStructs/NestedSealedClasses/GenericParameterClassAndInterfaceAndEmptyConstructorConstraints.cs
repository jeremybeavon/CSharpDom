namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedSealedClasses
{
    public class ClassWithNestedStructWithNestedSealedPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
