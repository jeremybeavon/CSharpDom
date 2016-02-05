﻿using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class FieldWithReflection : 
        AbstractField<AttributeWithReflection, ITypeWithReflection, ITypeReferenceWithReflection>,
        IHasFieldInfo
    {
        private readonly ITypeWithReflection declaringType;
        private readonly FieldInfo field;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithReflection fieldType;

        internal FieldWithReflection(ITypeWithReflection declaringType, FieldInfo field)
        {
            this.declaringType = declaringType;
            this.field = field;
            attributes = new Lazy<Attributes>(() => new Attributes(field));
            fieldType = TypeReferenceWithReflectionFactory.CreateReference(field.FieldType);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return declaringType; }
        }

        public FieldInfo FieldInfo
        {
            get { return field; }
        }

        public override ITypeReferenceWithReflection FieldType
        {
            get { return fieldType; }
        }

        public override FieldModifier Modifier
        {
            get
            {
                if (field.IsLiteral)
                {
                    return FieldModifier.Const;
                }

                if (field.IsStatic)
                {
                    if (field.IsInitOnly)
                    {
                        return FieldModifier.StaticReadOnly;
                    }

                    if (field.IsVolatile())
                    {
                        return FieldModifier.StaticVolatile;
                    }

                    return FieldModifier.Static;
                }

                if (field.IsInitOnly)
                {
                    return FieldModifier.ReadOnly;
                }

                if (field.IsVolatile())
                {
                    return FieldModifier.Volatile;
                }

                return FieldModifier.None;
            }
        }

        public override string Name
        {
            get { return field.Name; }
        }

        /*public override ClassMemberVisibilityModifier Visibility
        {
            get
            {
                if (field.IsPublic)
                {
                    return ClassMemberVisibilityModifier.Public;
                }

                if (field.IsAssembly)
                {
                    return ClassMemberVisibilityModifier.Internal;
                }

                if (field.IsFamilyOrAssembly)
                {
                    return ClassMemberVisibilityModifier.ProtectedInternal;
                }

                if (field.IsFamily)
                {
                    return ClassMemberVisibilityModifier.Protected;
                }

                if (field.IsPrivate)
                {
                    return ClassMemberVisibilityModifier.Private;
                }

                return ClassMemberVisibilityModifier.None;
            }
        }*/
    }
}