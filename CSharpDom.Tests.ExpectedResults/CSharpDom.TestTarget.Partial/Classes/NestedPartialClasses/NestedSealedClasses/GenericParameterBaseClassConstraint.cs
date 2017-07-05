namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedSealedClasses
{
    public class ClassWithNestedPartialClassWithNestedSealedPartialClassWithGenericParameterBaseClassConstraint
    {
        public partial class Class
        {
            public sealed class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
