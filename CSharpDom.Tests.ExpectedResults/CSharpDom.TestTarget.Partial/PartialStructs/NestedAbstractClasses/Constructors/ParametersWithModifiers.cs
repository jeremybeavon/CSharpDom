namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Constructors
{
    public partial struct PartialStructWithNestedAbstractClassWithConstructorWithParametersWithModifiers
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
