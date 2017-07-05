namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterBaseClassConstraint
    {
        public partial class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
