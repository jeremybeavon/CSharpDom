namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
