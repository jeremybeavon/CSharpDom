using System;
using System.Collections.ObjectModel;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class Class
    {
        public Class(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
            GenericParameters = new Collection<GenericParameter>();
            Interfaces = new Collection<InterfaceReference>();
            Body = new ClassBody();
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public string Name { get; set; }

        public TypeVisibilityModifier Visibility { get; set; }
        
        public Collection<GenericParameter> GenericParameters { get; set; }

        public ClassReference BaseClass { get; set; }

        public Collection<InterfaceReference> Interfaces { get; set; }

        public ClassBody Body { get; set; }
    }
}
