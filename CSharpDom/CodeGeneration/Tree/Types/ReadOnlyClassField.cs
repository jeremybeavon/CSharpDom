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
        private readonly IReadOnlyCollection<ReadOnlyConstant> constants;

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
            get
            {
                switch (field.Modifier)
                {
                    case FieldModifier.New:
                        return ClassFieldModifier.New;
                    case FieldModifier.NewStatic:
                        return ClassFieldModifier.NewStaticReadOnly;
                    case FieldModifier.NewStaticVolatile:
                        return ClassFieldModifier.NewStaticVolatile;
                    case FieldModifier.NewVolatile:
                        return ClassFieldModifier.NewVolatile;
                    case FieldModifier.None:
                        return ClassFieldModifier.None;
                    case FieldModifier.ReadOnly:
                        return ClassFieldModifier.ReadOnly;
                    case FieldModifier.Static:
                        return ClassFieldModifier.Static;
                    case FieldModifier.StaticReadOnly:
                        return ClassFieldModifier.StaticReadOnly;
                    case FieldModifier.StaticVolatile:
                        return ClassFieldModifier.StaticVolatile;
                    case FieldModifier.Volatile:
                        return ClassFieldModifier.Volatile;
                    default:
                        throw new NotSupportedException();

                }
            }
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
            get { return constants; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            if (field.Modifier == FieldModifier.Constant)
            {
                visitor.VisitClassConstant(this);
            }
            else
            {
                visitor.VisitClassField(this);
            }
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            if (field.Modifier == FieldModifier.Constant)
            {
                GenericVisitor.VisitClassConstantChildren(this, visitor);
            }
            else
            {
                GenericVisitor.VisitClassFieldChildren(this, visitor);
            }
        }
    }
}
