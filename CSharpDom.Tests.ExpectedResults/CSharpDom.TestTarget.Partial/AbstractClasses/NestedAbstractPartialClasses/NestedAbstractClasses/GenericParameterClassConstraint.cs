namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNestedAbstractPartialClassWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
