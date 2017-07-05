namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedAbstractPartialClassWithGenericParameterBaseClassConstraint
    {
        public sealed partial class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
