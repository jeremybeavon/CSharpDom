namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedClasses
{
    public partial struct PartialStructWithNestedAbstractClassWithNestedClassWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
