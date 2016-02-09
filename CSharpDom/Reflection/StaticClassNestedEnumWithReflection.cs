﻿using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class StaticClassNestedEnumWithReflection :
        AbstractStaticClassNestedEnum<
            AttributeWithReflection,
            ITypeWithReflection,
            NestedEnumMemberWithReflection>
    {
        private readonly NestedEnumWithReflection nestedEnum;

        internal StaticClassNestedEnumWithReflection(ITypeWithReflection declaringType, Type type)
        {
            nestedEnum = new NestedEnumWithReflection(declaringType, type);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override EnumBaseType BaseType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ITypeWithReflection DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyList<NestedEnumMemberWithReflection> EnumMembers
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}