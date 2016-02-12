using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructField :
        AbstractStructField<AttributeGroupNotSupported, IStructType, ReadOnlyTypeReference, ReadOnlyField`>
    {
        private readonly StructField field;
        private readonly ReadOnlyTypeReference fieldType;

        public ReadOnlyStructField(StructField field)
        {
            this.field = field;
            fieldType = new ReadOnlyTypeReference(field.Type);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IStructType DeclaringType
        {
            get { return null; }
        }

        public override IReadOnlyCollection<ReadOnlyField> Fields
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ReadOnlyTypeReference FieldType
        {
            get { return fieldType; }
        }

        public override StructFieldModifier Modifier
        {
            get { return field.Modifier; }
        }

        public override string Name
        {
            get { return field.Fields[0].Name; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return field.Visibility; }
        }
    }
}
