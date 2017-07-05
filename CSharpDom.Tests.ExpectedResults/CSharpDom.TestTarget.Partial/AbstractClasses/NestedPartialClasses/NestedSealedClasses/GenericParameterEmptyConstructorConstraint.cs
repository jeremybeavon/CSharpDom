namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedSealedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
