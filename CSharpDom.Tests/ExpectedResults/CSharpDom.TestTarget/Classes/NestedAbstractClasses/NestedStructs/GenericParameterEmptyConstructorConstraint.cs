namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedStructs
{
    public class ClassWithNestedAbstractClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
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
