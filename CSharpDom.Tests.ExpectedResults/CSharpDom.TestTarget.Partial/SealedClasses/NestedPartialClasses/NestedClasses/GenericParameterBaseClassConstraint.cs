namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedClasses
{
    public sealed class SealedClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterBaseClassConstraint
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
