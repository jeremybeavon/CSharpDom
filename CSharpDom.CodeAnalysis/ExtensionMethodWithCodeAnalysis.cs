using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ExtensionMethodWithCodeAnalysis :
        EditableExtensionMethod<
            AttributeGroupWithCodeAnalysis,
            IStaticClass,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            ExtensionParameterWithCodeAnalysis,
            MethodParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>
    {
        private readonly MethodWithCodeAnalysis method;
        private readonly ExtensionParameterWithCodeAnalysis extensionParameter;
        private readonly IReadOnlyList<MethodParameterWithCodeAnalysis> parameters;

        internal ExtensionMethodWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, MethodDefinition method)
        {
            this.method = new MethodWithCodeAnalysis(declaringType, method);
            extensionParameter = new ExtensionParameterWithCodeAnalysis(this.method.Parameters[0]);
            parameters = this.method.Parameters.Skip(1).ToArray();
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

        public override IReadOnlyList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return method.GenericParameters; }
        }
        
        public override string Name
        {
            get { return method.Name; }
        }

        public override IReadOnlyList<MethodParameterWithCodeAnalysis> Parameters
        {
            get { return parameters; }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return method.ReturnType; }
        }

        public override ExtensionParameterWithCodeAnalysis ExtensionParameter
        {
            get { return extensionParameter; }
        }

        public override bool IsAsync
        {
            get { return method.IsAsync; }
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> ReturnAttributes
        {
            get { return method.ReturnAttributes; }
        }
    }
}
