namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedStructs
{
    public class ClassWithNestedAbstractPartialClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public abstract partial class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
