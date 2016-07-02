namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedStaticClasses
{
    public class ClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
