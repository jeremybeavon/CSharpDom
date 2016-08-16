using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using System.Reflection;
using CSharpDom.Mono.Cecil.ConstantExpressions;
using CSharpDom.NotSupported;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassFieldWithCodeAnalysis :
        AbstractClassField<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            IFieldWithCodeAnalysis>,
        IFieldWithCodeAnalysis
    {
        private readonly FieldGroupWithCodeAnalysis field;
        private readonly IInternalTypeWithCodeAnalysis declaringType;

        internal ClassFieldWithCodeAnalysis(IInternalTypeWithCodeAnalysis declaringType, FieldDefinition field)
        {
            this.field = new FieldGroupWithCodeAnalysis(declaringType, field);
            this.declaringType = declaringType;
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return field.Attributes; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return field.DeclaringType; }
        }

        public override ITypeReferenceWithCodeAnalysis FieldType
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

        public override IReadOnlyCollection<IFieldWithCodeAnalysis> Fields
        {
            get { return new IFieldWithCodeAnalysis[] { new InternalFieldWithCodeAnalysis(field.FieldDefinition) }; }
        }

        public ExpressionNotSupported InitialValue
        {
            get { return new ExpressionNotSupported(); }
        }
    }
}
