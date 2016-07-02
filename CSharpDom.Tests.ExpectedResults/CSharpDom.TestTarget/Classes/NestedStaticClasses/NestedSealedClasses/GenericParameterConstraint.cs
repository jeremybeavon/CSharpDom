namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedSealedClasses
{
    public class ClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
