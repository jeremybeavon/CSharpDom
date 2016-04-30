namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedAbstractClasses
{
    public struct StructWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
