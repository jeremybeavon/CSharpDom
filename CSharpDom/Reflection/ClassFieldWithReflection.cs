using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class ClassFieldWithReflection :
        AbstractClassField<
            AttributeWithReflection,
            ITypeWithReflection,
            ITypeReferenceWithReflection>
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

        public override string Name
        {
            get { return field.Name; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return field.FieldInfo.ClassVisibility(); }
        }
    }
}
