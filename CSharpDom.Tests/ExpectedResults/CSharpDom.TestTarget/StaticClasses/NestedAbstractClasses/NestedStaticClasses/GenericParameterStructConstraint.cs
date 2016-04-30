namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
