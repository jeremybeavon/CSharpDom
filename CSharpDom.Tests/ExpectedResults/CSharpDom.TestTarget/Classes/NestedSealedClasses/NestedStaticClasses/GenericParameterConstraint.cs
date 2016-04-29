namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedStaticClasses
{
    public class ClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
