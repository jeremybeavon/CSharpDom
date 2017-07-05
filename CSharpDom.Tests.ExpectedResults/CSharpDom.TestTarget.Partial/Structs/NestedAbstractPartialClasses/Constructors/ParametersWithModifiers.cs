namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Constructors
{
    public struct StructWithNestedAbstractPartialClassWithConstructorWithParametersWithModifiers
    {
        public abstract partial class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
