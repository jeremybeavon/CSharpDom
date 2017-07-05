namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedSealedClasses
{
    public class ClassWithNestedAbstractPartialClassWithNestedSealedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract partial class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
