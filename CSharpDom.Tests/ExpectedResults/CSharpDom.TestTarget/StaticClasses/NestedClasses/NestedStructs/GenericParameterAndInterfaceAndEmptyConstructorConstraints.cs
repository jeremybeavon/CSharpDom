namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedStructs
{
    public static class StaticClassWithNestedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
