namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
