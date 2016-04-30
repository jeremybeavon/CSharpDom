namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
