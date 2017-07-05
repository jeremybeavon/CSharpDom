namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedClasses
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNestedClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
