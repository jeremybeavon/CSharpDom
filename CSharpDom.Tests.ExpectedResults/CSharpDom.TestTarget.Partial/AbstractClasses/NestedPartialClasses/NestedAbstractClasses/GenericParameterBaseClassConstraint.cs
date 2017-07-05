namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedAbstractPartialClassWithGenericParameterBaseClassConstraint
    {
        public partial class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
