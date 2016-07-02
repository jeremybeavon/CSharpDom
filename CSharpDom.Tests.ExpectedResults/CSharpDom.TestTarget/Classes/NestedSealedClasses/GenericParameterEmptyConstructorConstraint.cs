namespace CSharpDom.TestTarget.Classes.NestedSealedClasses
{
    public class ClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class<T>
            where T : new()
        {
        }
    }
}
