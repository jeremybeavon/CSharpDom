namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
