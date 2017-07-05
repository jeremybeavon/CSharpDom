namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
