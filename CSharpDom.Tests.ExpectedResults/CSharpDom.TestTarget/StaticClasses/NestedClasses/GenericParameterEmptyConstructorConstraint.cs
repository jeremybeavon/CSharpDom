namespace CSharpDom.TestTarget.StaticClasses.NestedClasses
{
    public static class StaticClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public class Class<T>
            where T : new()
        {
        }
    }
}
