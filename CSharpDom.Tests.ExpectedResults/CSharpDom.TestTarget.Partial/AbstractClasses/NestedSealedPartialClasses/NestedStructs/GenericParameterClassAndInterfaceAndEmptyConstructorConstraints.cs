namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed partial class Class
        {
            public struct NestedStruct<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
