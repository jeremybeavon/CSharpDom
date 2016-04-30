namespace CSharpDom.TestTarget.SealedClasses.NestedClasses
{
    public sealed class SealedClassWithNestedClassWithGenericParameterStructConstraint
    {
        public class Class<T>
            where T : struct
        {
        }
    }
}
