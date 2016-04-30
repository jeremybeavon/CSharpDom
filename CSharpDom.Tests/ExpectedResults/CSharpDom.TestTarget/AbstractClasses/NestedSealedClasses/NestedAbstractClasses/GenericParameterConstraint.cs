namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
