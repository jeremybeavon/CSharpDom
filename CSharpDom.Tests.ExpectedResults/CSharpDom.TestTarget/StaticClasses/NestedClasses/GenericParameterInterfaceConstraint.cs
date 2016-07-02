namespace CSharpDom.TestTarget.StaticClasses.NestedClasses
{
    public static class StaticClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public class Class<T>
            where T : IInterface
        {
        }
    }
}
