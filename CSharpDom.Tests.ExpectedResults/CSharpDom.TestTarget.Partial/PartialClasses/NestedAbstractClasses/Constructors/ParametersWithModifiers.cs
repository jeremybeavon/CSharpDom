namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Constructors
{
    public partial class PartialClassWithNestedAbstractClassWithConstructorWithParametersWithModifiers
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
