namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
