namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
