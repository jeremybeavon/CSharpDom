namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
