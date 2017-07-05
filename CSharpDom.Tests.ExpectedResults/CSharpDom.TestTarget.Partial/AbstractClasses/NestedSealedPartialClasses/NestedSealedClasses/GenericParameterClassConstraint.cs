namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedSealedPartialClassWithGenericParameterClassConstraint
    {
        public sealed partial class Class
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
