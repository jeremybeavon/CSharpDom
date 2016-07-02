namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
