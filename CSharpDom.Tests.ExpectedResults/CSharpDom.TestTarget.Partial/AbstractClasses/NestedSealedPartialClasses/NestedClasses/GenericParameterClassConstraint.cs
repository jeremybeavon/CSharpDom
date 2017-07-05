namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public sealed partial class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
