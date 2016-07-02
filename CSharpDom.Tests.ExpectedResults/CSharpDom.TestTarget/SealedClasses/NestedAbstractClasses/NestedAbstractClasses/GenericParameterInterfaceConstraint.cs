namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
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
