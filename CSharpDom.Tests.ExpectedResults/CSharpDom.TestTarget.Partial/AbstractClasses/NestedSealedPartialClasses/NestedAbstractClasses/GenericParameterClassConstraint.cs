namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedAbstractPartialClassWithGenericParameterClassConstraint
    {
        public sealed partial class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
