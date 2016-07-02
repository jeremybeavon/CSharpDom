namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedSealedClasses
{
    public class ClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
