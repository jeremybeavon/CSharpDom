namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedClasses
{
    public partial class PartialClassWithNestedClassWithNestedClassWithGenericParameterInterfaceConstraint
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
