namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
