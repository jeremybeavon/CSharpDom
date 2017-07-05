namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterInterfaceConstraint
    {
        public partial class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
