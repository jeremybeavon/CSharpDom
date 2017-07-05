namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedClasses
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
