namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedClassWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
