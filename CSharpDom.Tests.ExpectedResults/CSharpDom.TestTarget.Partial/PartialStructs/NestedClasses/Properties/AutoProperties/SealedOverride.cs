﻿namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Properties.AutoProperties
{
    public partial struct PartialStructWithNestedClassWithSealedOverrideAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property { get; set; }
        }
    }
}
