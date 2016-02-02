﻿using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassFieldDeclaration :
        AbstractClassField<AttributeGroupNotSupported, IType, ReadOnlyTypeReference>
    {
        private readonly ClassFieldDeclaration field;
        private readonly ReadOnlyTypeReference fieldType;

        public ReadOnlyClassFieldDeclaration(ClassFieldDeclaration field)
        {
            this.field = field;
            fieldType = new ReadOnlyTypeReference(field.Type);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IType DeclaringType
        {
            get { return null; }
        }

        public override ReadOnlyTypeReference FieldType
        {
            get { return fieldType; }
        }

        public override FieldModifier Modifier
        {
            get { return field.Modifier; }
        }

        public override string Name
        {
            get { return field.Fields[0].Name; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return ReadOnlyClass.GetVisibility(field.Visibility); }
        }
    }
}
