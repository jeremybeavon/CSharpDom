namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedStaticClasses
{
    public struct StructWithNestedClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
