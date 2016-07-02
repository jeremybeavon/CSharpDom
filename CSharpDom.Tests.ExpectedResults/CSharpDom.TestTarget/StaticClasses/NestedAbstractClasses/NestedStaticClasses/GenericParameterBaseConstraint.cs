namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
