namespace CSharpDom.TestTarget.StaticClasses.NestedClasses
{
    public static class StaticClassWithNestedClassWithGenericParameterStructConstraint
    {
        public class Class<T>
            where T : struct
        {
        }
    }
}
