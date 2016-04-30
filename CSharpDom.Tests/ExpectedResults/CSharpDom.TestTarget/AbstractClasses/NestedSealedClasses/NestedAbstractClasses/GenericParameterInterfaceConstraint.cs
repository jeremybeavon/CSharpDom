namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
