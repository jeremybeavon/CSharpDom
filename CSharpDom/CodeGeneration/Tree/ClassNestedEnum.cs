﻿using CSharpDom.CodeGeneration.Tree.Types;
using CSharpDom.Text;
using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassNestedEnum
    {
        public ClassNestedEnum(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
            Fields = new Collection<EnumField>();
            Visibility = ClassMemberVisibilityModifier.Private;
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        public string Name { get; set; }

        public EnumBaseType BaseType { get; set; }

        public Collection<EnumField> Fields { get; set; }

        public override string ToString()
        {
            return new ReadOnlyClassNestedEnum(this).ToSourceCode();
        }
    }
}
