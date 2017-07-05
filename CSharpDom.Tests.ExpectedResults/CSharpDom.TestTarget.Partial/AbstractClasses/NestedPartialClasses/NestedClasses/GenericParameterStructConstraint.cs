namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
