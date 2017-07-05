namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedStructs
{
    public class ClassWithNestedAbstractPartialClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract partial class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
