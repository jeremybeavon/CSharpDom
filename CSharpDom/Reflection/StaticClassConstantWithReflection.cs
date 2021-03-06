﻿using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using System.Reflection;
using CSharpDom.NotSupported;
using CSharpDom.Reflection.Internal;
using CSharpDom.Reflection.ConstantExpressions;

namespace CSharpDom.Reflection
{
    public sealed class StaticClassConstantWithReflection :
        AbstractStaticClassConstant<
            AttributeWithReflection,
            ITypeWithReflection,
            ITypeReferenceWithReflection,
            IConstantWithReflection>,
        IConstantWithReflection
    {
        private readonly ConstantGroupWithReflection constant;

        internal StaticClassConstantWithReflection(ITypeWithReflection declaringType, FieldInfo field)
        {
            this.constant = new ConstantGroupWithReflection(declaringType, field);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return constant.Attributes; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return constant.DeclaringType; }
        }

        public override IReadOnlyCollection<IConstantWithReflection> Constants
        {
            get { return new IConstantWithReflection[] { new InternalConstantWithReflection(constant) }; }
        }

        public override ITypeReferenceWithReflection FieldType
        {
            get { return constant.FieldType; }
        }

        public IConstantExpressionWithReflection ConstantValue
        {
            get { return constant.ConstantValue; }
        }
        
        public string Name
        {
            get { return constant.FieldInfo.Name; }
        }

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get
            {
                FieldInfo fieldInfo = constant.FieldInfo;
                if (fieldInfo.IsPublic)
                {
                    return StaticClassMemberVisibilityModifier.Public;
                }

                if (fieldInfo.IsAssembly)
                {
                    return StaticClassMemberVisibilityModifier.Internal;
                }

                if (fieldInfo.IsPrivate)
                {
                    return StaticClassMemberVisibilityModifier.Private;
                }

                return StaticClassMemberVisibilityModifier.None;
            }
        }
    }
}
