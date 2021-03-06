﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Properties
{
    public partial struct PartialStructWithNestedAbstractClassWithNewVirtualProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new virtual string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
