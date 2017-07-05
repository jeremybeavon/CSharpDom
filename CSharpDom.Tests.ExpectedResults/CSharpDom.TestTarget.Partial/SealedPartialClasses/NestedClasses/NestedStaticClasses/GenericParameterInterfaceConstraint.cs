namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
