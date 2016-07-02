namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedClassWithNestedSealedClassWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public sealed class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
