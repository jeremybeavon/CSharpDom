namespace CSharpDom.TestTarget.StaticClasses.NestedClasses
{
    public static class StaticClassWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public class Class<T>
            where T : BaseClass
        {
        }
    }
}
