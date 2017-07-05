namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNestedSealedPartialClassWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
