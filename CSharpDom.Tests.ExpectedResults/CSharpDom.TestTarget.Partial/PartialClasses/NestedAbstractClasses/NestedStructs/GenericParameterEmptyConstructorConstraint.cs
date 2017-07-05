namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedStructs
{
    public partial class PartialClassWithNestedAbstractClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
