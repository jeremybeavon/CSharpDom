namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedClasses
{
    public struct StructWithNestedStaticClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
