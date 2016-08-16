using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ExplicitInterfaceMethodWithCodeAnalysis :
        AbstractExplicitInterfaceMethod<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            MethodParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>
    {
        private readonly MethodWithCodeAnalysis method;
        private readonly string name;
        private readonly InterfaceReferenceWithCodeAnalysis explicitInterface;

        internal ExplicitInterfaceMethodWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, MethodDefinition method)
        {
            this.method = new MethodWithCodeAnalysis(declaringType, method);
            name = method.Name.Split('.').Last();
            TypeReference interfaceType = method.FindExplicitInterface();
            explicitInterface = new InterfaceReferenceWithCodeAnalysis(declaringType.Assembly, interfaceType);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return method.Attributes; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return method.Body; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return method.DeclaringType; }
        }

        public override InterfaceReferenceWithCodeAnalysis ExplicitInterface
        {
            get { return explicitInterface; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return method.GenericParameters; }
        }

        public override bool IsAsync
        {
            get { return method.IsAsync; }
        }

        public override string Name
        {
            get { return name; }
        }

        public override IReadOnlyList<MethodParameterWithCodeAnalysis> Parameters
        {
            get { return method.Parameters; }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return method.ReturnType; }
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> ReturnAttributes
        {
            get { return method.ReturnAttributes; }
        }
    }
}
