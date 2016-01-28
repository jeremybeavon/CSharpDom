﻿using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyInterfaceMethod :
        AbstractMethod<
            AttributeGroupNotSupported,
            IBasicType,
            ReadOnlyGenericParameterDeclaration,
            ReadOnlyTypeReference,
            ReadOnlyMethodParameter,
            MethodBodyNotSupported>
    {
        private readonly InterfaceMethod interfaceMethod;
        private readonly IReadOnlyList<ReadOnlyGenericParameterDeclaration> genericParameters;
        private readonly IReadOnlyList<ReadOnlyMethodParameter> parameters;
        private readonly ReadOnlyTypeReference returnType;

        public ReadOnlyInterfaceMethod(InterfaceMethod interfaceMethod)
        {
            this.interfaceMethod = interfaceMethod;
            genericParameters = ReadOnlyGenericParameterDeclaration.Create(interfaceMethod.GenericParameters);
            parameters = ReadOnlyMethodParameter.Create(interfaceMethod.Parameters);
            returnType = new ReadOnlyTypeReference(interfaceMethod.ReturnType);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override MethodBodyNotSupported Body
        {
            get { return new MethodBodyNotSupported(); }
        }

        public override IBasicType DeclaringType
        {
            get { return null; }
        }

        public override IReadOnlyList<ReadOnlyGenericParameterDeclaration> GenericParameters
        {
            get { return genericParameters; }
        }

        public override MemberInheritanceModifier InheritanceModifier
        {
            get { return interfaceMethod.IsNew ? MemberInheritanceModifier.New : MemberInheritanceModifier.None; }
        }

        public override string Name
        {
            get { return interfaceMethod.Name; }
        }

        public override IReadOnlyList<ReadOnlyMethodParameter> Parameters
        {
            get { return parameters; }
        }

        public override ReadOnlyTypeReference ReturnType
        {
            get { return returnType; }
        }

        public override MemberVisibilityModifier Visibility
        {
            get { return MemberVisibilityModifier.None; }
        }

        public static IReadOnlyCollection<ReadOnlyInterfaceMethod> Create(IEnumerable<InterfaceMethod> interfaceMethods)
        {
            return interfaceMethods.ToArray(interfaceMethod => new ReadOnlyInterfaceMethod(interfaceMethod));
        }
    }
}
