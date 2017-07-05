namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedClasses
{
    public partial class PartialClassWithNestedAbstractClassWithNestedClassWithGenericParameterInterfaceConstraint
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
