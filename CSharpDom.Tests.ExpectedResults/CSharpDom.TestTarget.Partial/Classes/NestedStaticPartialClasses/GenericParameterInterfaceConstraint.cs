namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticClasses
{
    public class ClassWithNestedStaticPartialClassWithGenericParameterInterfaceConstraint
    {
        public static class Class<T>
            where T : IInterface
        {
        }
    }
}
