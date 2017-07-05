namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.NestedAbstractClasses
{
    public partial struct PartialStructWithWithNestedClassWithNestedAbstractClassWithGenericParameterClassConstraint
    {
        public class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
