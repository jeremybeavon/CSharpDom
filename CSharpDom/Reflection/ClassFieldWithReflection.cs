using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System.Reflection;
using CSharpDom.Reflection.ConstantExpressions;
using CSharpDom.NotSupported;

namespace CSharpDom.Reflection
{
    public sealed class ClassFieldWithReflection :
        AbstractClassField<
            AttributeWithReflection,
            ITypeWithReflection,
            ITypeReferenceWithReflection,
            IFieldWithReflection>,
        IFieldWithReflection
    {
        private readonly FieldGroupWithReflection field;
        private readonly IInternalTypeWithReflection declaringType;

        internal ClassFieldWithReflection(IInternalTypeWithReflection declaringType, FieldInfo field)
        {
            this.field = new FieldGroupWithReflection(declaringType, field);
            this.declaringType = declaringType;
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return field.Attributes; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return field.DeclaringType; }
        }

        public override ITypeReferenceWithReflection FieldType
        {
            get { return field.FieldType; }
        }

        public override ClassFieldModifier Modifier
        {
            get { return field.Modifier; }
        }

        public string Name
        {
            get { return field.FieldInfo.Name; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return field.FieldInfo.ClassVisibility(); }
        }

        public override IReadOnlyCollection<IFieldWithReflection> Fields
        {
            get { return new IFieldWithReflection[] { this }; }
        }

        public ExpressionNotSupported InitialValue
        {
            get { return new ExpressionNotSupported(); }
        }
    }
}
