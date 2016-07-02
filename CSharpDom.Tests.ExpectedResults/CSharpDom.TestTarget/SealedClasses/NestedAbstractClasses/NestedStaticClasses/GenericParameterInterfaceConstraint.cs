namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
