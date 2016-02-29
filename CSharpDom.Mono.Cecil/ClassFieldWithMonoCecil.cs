using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using System.Reflection;
using CSharpDom.Mono.Cecil.ConstantExpressions;
using CSharpDom.NotSupported;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ClassFieldWithMonoCecil :
        AbstractClassField<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            IFieldWithMonoCecil>,
        IFieldWithMonoCecil
    {
        private readonly FieldGroupWithMonoCecil field;
        private readonly IInternalTypeWithMonoCecil declaringType;

        internal ClassFieldWithMonoCecil(IInternalTypeWithMonoCecil declaringType, FieldDefinition field)
        {
            this.field = new FieldGroupWithMonoCecil(declaringType, field);
            this.declaringType = declaringType;
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return field.Attributes; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return field.DeclaringType; }
        }

        public override ITypeReferenceWithMonoCecil FieldType
        {
            get { return field.FieldType; }
        }

        public override ClassFieldModifier Modifier
        {
            get { return field.Modifier; }
        }

        public string Name
        {
            get { return field.FieldDefinition.Name; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return field.FieldDefinition.ClassVisibility(); }
        }

        public override IReadOnlyCollection<IFieldWithMonoCecil> Fields
        {
            get { return new IFieldWithMonoCecil[] { this }; }
        }

        public ExpressionNotSupported InitialValue
        {
            get { return new ExpressionNotSupported(); }
        }
    }
}
