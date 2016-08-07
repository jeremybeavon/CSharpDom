namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public sealed class Class
        {
            public static class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
