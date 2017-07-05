namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedClasses
{
    public sealed class SealedClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterClassConstraint
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
