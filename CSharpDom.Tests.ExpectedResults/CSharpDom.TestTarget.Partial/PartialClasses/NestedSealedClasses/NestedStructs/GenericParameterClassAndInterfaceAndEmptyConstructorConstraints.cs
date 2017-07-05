namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedStructs
{
    public partial class PartialClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
