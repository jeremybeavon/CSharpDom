namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
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
