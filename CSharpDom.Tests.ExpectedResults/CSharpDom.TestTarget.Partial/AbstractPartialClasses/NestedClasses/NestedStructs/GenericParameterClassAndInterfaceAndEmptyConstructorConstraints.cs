namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedStructs
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
