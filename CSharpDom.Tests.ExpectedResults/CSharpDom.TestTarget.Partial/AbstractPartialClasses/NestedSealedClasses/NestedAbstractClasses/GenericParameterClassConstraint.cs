namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedAbstractClasses
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
