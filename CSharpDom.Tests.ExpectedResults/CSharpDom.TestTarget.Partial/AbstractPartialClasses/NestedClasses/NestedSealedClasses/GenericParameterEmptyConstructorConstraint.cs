namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedSealedClasses
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
