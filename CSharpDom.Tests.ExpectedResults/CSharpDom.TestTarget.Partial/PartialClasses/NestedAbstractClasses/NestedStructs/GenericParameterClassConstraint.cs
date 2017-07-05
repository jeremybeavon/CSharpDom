namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedStructs
{
    public partial class PartialClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
