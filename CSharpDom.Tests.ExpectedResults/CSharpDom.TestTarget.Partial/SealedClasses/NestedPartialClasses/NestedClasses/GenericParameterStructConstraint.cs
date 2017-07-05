namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedClasses
{
    public sealed class SealedClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterStructConstraint
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
