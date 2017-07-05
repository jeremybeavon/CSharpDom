namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
