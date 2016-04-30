namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
