namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
