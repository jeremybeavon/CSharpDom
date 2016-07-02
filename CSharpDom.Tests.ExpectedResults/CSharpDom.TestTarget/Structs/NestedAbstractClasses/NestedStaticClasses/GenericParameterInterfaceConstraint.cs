namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedStaticClasses
{
    public struct StructWithNestedAbstractClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
