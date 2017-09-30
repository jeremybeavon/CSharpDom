using System;
using System.Collections.ObjectModel;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StaticClassNestedAbstractClass
    {
        public StaticClassNestedAbstractClass(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
            GenericParameters = new Collection<GenericParameter>();
            Interfaces = new Collection<InterfaceReference>();
            Body = new AbstractClassBody();
            Visibility = StaticClassMemberVisibilityModifier.Private;
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public string Name { get; set; }

        public StaticClassMemberVisibilityModifier Visibility { get; set; }
        
        public Collection<GenericParameter> GenericParameters { get; set; }

        public ClassReference BaseClass { get; set; }

        public Collection<InterfaceReference> Interfaces { get; set; }

        public AbstractClassBody Body { get; set; }
    }
}
