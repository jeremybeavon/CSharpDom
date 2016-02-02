﻿using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection
{
    public sealed class InterfaceMethodWithReflection :
        AbstractInterfaceMethod<
            AttributeWithReflection,
            IBasicTypeWithReflection,
            GenericParameterDeclarationWithReflection,
            ITypeReferenceWithReflection,
            ParameterWithReflection>
    {
        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IBasicTypeWithReflection DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override InterfaceMemberInheritanceModifier InheritanceModifier
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override bool IsAsync
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override bool IsPartial
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

        public override IReadOnlyList<ParameterWithReflection> Parameters
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ITypeReferenceWithReflection ReturnType
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
