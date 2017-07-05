namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedSealedClasses
{
    public class ClassWithNestedPartialClassWithNestedSealedPartialClassWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
