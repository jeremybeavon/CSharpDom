namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedClasses
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedClassWithGenericParameterInterfaceConstraint
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
