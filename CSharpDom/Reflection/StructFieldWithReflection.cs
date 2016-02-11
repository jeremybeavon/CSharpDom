﻿using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class StructFieldWithReflection :
        AbstractStructField<
            AttributeWithReflection,
            ITypeWithReflection,
            ITypeReferenceWithReflection>
    {
        private readonly FieldGroupWithReflection field;

        internal StructFieldWithReflection(ITypeWithReflection declaringType, FieldInfo field)
        {
            this.field = new FieldGroupWithReflection(declaringType, field);
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

        public override StructFieldModifier Modifier
        {
            get { throw new NotImplementedException(); }
            //get { return field.Modifier; }
        }

        public override string Name
        {
            get { return field.Name; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get
            {
                FieldInfo fieldInfo = field.FieldInfo;
                if (fieldInfo.IsPublic)
                {
                    return StructMemberVisibilityModifier.Public;
                }

                if (fieldInfo.IsAssembly)
                {
                    return StructMemberVisibilityModifier.Internal;
                }
                
                if (fieldInfo.IsPrivate)
                {
                    return StructMemberVisibilityModifier.Private;
                }

                return StructMemberVisibilityModifier.None;
            }
        }
    }
}
