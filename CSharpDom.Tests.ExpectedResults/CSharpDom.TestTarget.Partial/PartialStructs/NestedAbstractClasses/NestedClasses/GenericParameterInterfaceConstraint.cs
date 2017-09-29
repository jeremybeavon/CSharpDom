namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedClasses
{
    public partial struct PartialStructWithNestedAbstractClassWithNestedClassWithGenericParameterInterfaceConstraint
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
