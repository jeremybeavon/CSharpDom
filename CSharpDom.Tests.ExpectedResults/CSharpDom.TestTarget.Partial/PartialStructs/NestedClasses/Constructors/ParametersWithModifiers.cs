﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Constructors
{
    public partial struct PartialStructWithNestedClassWithConstructorWithParametersWithModifiers
    {
        public class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
