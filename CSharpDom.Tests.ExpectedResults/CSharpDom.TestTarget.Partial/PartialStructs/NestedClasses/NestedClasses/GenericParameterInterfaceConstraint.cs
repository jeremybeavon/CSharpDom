namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedClasses
{
    public partial struct PartialStructWithWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraint
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
