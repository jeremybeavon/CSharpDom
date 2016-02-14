using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStaticClassField :
        AbstractStaticClassField<AttributeGroupNotSupported, IStaticType, ReadOnlyTypeReference, ReadOnlyField>
    {
        private readonly StaticClassField field;
        private readonly ReadOnlyTypeReference fieldType;

        public ReadOnlyStaticClassField(StaticClassField field)
        {
            this.field = field;
            fieldType = new ReadOnlyTypeReference(field.Type);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IStaticType DeclaringType
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

        public override StaticClassFieldModifier Modifier
        {
            get { return field.Modifier; }
        }

        public override string Name
        {
            get { return field.Fields[0].Name; }
        }

        public override StaticClassMemberVisibilityModifier InheritanceModifier
        {
            get { return field.Visibility; }
        }
    }
}
