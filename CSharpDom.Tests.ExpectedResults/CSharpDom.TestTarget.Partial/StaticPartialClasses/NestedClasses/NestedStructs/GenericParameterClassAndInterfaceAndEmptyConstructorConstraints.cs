namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedStructs
{
    public static partial class StaticPartialClassWithNestedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
