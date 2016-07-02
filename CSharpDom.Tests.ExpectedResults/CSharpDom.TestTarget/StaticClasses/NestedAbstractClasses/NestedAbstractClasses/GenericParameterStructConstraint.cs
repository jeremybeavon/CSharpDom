namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
