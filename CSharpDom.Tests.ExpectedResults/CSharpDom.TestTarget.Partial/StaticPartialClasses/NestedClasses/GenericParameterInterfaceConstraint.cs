namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public class Class<T>
            where T : IInterface
        {
        }
    }
}
