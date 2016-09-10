using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
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
            MethodBodyWithCodeAnalysis>,
        IHasSyntax<MethodDeclarationSyntax>,
        IHasId
    {
        private readonly Guid internalId;
        private readonly MethodWithBodyWithCodeAnalysis method;
        private readonly ExtensionParameterWithCodeAnalysis extensionParameter;
        private readonly IList<MethodParameterWithCodeAnalysis> parameters;

        internal ExtensionMethodWithCodeAnalysis(StaticTypeWithCodeAnalysis parent)
        {
            internalId = Guid.NewGuid();
            method = new MethodWithBodyWithCodeAnalysis(parent, this);
            extensionParameter = new ExtensionParameterWithCodeAnalysis(this);
            parameters = new FilteredList<MethodParameterWithCodeAnalysis, MethodParameterWithCodeAnalysis>(
                method.Parameters,
                parameter => !parameter.Syntax.Modifiers.Any(SyntaxKind.ThisKeyword));
        }

        public MethodWithBodyWithCodeAnalysis Method
        {
            get { return method; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return method.Attributes; }
            set { method.Attributes = value; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return method.Body; }
            set { method.Body = value; }
        }

        public override IStaticClass DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return method.GenericParameters; }
            set { method.GenericParameters = value; }
        }
        
        public override string Name
        {
            get { return method.Name; }
            set { method.Name = value; }
        }

        public override IList<MethodParameterWithCodeAnalysis> Parameters
        {
            get { return parameters; }
            set
            {
                IList<MethodParameterWithCodeAnalysis> parameters = method.Parameters;
                int parameterCount = parameters.Count - 1;
                for (int index = 0; index < value.Count; index++)
                {
                    if (index < parameterCount)
                    {
                        parameters[index + 1] = value[index];
                    }
                    else
                    {
                        parameters.Add(value[index]);
                    }
                }

                while (parameters.Count - 1 > value.Count)
                {
                    parameters.RemoveAt(value.Count);
                }
            }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return method.ReturnType; }
            set { method.ReturnType = value; }
        }

        public override ExtensionParameterWithCodeAnalysis ExtensionParameter
        {
            get { return extensionParameter; }
            set { method.Parameters[0].Syntax = value.Syntax; }
        }

        public override bool IsAsync
        {
            get { return method.IsAsync; }
            set { method.IsAsync = value; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> ReturnAttributes
        {
            get { return method.ReturnAttributes; }
            set { method.ReturnAttributes = value; }
        }

        public MethodDeclarationSyntax Syntax
        {
            get { return method.Syntax; }
            set { method.Syntax = value; }
        }

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }
    }
}
