namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
