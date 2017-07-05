namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedStructs
{
    public partial class PartialClassWithNestedAbstractClassWithNestedStructWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
