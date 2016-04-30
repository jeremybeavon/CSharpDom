namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterStructConstraint
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
