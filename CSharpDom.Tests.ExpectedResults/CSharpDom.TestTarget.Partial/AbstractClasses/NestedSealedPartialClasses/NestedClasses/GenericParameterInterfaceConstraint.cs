namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterInterfaceConstraint
    {
        public sealed partial class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
