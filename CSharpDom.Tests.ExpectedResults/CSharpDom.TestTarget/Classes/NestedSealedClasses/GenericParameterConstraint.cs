namespace CSharpDom.TestTarget.Classes.NestedSealedClasses
{
    public class ClassWithNestedSealedClassWithGenericParameterClassConstraint
    {
        public sealed class Class<T>
            where T : class
        {
        }
    }
}
