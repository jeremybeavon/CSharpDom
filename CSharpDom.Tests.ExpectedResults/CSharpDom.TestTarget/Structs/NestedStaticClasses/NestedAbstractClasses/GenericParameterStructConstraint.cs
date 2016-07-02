namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedAbstractClasses
{
    public struct StructWithNestedStaticClassWithNestedAbstractClassWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
