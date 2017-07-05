namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedClasses
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedClassWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
