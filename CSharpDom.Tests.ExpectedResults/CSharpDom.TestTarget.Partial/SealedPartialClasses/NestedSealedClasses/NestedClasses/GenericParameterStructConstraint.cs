namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedClassWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
