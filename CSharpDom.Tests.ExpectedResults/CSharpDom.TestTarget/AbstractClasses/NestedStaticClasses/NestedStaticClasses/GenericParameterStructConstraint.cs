namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
