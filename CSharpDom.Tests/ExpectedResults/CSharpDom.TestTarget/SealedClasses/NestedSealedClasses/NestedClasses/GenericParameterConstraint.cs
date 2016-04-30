namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedClasses
{
    public sealed class SealedClassWithNestedSealedClassWithNestedClassWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
