using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassField :
        IClassField<AttributeGroupNotSupported, IClassType, ReadOnlyTypeReference, ReadOnlyField>,
        IClassConstant<AttributeGroupNotSupported, IClassType, ReadOnlyTypeReference, ReadOnlyConstant>
    {
        private readonly ClassField field;
        private readonly ReadOnlyTypeReference fieldType;
        private readonly IReadOnlyCollection<ReadOnlyField> fields;
        //private readonly IReadOnlyCollection<ReadOnlyConstant> constants;

        public ReadOnlyClassField(ClassField field)
        {
            this.field = field;
            fieldType = new ReadOnlyTypeReference(field.Type);
            fields = field.Fields.ToArray(child => new ReadOnlyField(child));
        }

        public IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public IClassType DeclaringType
        {
            get { return null; }
        }

        public IReadOnlyCollection<ReadOnlyField> Fields { get; private set; }

        public ReadOnlyTypeReference FieldType
        {
            get { return fieldType; }
        }

        public ClassFieldModifier Modifier
        {
            get { return field.Modifier; }
        }

        public string Name
        {
            get { return field.Fields[0].Name; }
        }

        public ClassMemberVisibilityModifier Visibility
        {
            get { return field.Visibility; }
        }

        public IReadOnlyCollection<ReadOnlyConstant> Constants
        {
            get { throw new NotImplementedException(); }
            //get { return constants; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassField(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassFieldChildren(this, visitor);
        }
    }
}
