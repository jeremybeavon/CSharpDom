namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterBaseClassConstraint
    {
        public sealed partial class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
