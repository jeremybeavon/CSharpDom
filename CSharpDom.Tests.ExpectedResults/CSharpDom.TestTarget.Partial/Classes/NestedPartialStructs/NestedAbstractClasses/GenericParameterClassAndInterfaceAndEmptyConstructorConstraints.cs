namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedAbstractClasses
{
    public class ClassWithNestedStructWithNestedAbstractPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public abstract class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
