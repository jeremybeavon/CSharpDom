namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedClasses
{
    public sealed class SealedClassWithNestedStaticClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
