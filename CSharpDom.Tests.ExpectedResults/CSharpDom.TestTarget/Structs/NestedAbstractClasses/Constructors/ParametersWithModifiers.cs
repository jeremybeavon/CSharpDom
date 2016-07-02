namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Constructors
{
    public struct StructWithNestedAbstractClassWithConstructorWithParametersWithModifiers
    {
        public abstract class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
