namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedClasses
{
    public class ClassWithNestedSealedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class<T>
            where T : new()
        {
        }
    }
}
