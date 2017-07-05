namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedClasses
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterStructConstraint
    {
        public sealed partial class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
