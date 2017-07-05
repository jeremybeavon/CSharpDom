namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedClasses
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
