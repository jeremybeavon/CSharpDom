namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedStructs
{
    public sealed class SealedClassWithNestedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class
        {
            public struct NestedStruct<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
