namespace CSharpDom.TestTarget.Classes.NestedSealedClasses
{
    public class ClassWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public sealed class Class<T>
            where T : struct
        {
        }
    }
}
