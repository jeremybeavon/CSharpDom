namespace CSharpDom.TestTarget.SealedClasses.NestedClasses
{
    public sealed class SealedClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class<T>
            where T : new()
        {
        }
    }
}
