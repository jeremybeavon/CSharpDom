namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint
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
