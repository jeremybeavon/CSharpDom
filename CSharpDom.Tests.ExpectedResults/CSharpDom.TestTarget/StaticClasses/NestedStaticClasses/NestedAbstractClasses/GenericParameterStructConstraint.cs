namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterStructConstraint
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
