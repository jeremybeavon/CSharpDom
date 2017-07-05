namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
