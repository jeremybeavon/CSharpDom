namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
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
