namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
