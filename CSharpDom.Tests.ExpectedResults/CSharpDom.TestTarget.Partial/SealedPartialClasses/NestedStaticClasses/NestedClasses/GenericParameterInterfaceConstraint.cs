namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
