﻿using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class SealedClassField
    {
        public SealedClassField(TypeReference type)
        {
            Type = type;
            Fields = new Collection<Field>();
        }

        public ClassMemberVisibilityModifier Visibility { get; set; }

        public ClassFieldModifier Modifier { get; set; }
        
        public TypeReference Type { get; set; }

        public Collection<Field> Fields { get; set; }
    }
}
