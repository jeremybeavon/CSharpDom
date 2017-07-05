namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedAbstractClasses
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
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
