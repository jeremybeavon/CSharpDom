namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedClasses
{
    public static class StaticClassWithNestedPartialClassWithGenericParameterInterfaceConstraint
    {
        public class Class<T>
            where T : IInterface
        {
        }
    }
}
