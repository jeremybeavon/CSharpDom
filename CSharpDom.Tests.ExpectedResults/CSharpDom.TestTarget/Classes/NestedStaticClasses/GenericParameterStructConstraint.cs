namespace CSharpDom.TestTarget.Classes.NestedStaticClasses
{
    public class ClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public static class Class<T>
            where T : struct
        {
        }
    }
}
