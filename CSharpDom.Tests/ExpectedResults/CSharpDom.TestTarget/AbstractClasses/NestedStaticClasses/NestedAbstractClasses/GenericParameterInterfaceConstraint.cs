namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
