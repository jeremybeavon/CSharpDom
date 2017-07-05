namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedStructs
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
