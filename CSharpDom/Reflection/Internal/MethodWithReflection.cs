using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class MethodWithReflection :
        AbstractMethod<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            ITypeReferenceWithReflection,
            MethodParameterWithReflection,
            ILMethodBodyWithReflectionEmit>,
        IHasMethodInfo
    {
        private readonly ITypeWithReflection declaringType;
        private readonly MethodInfo method;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<Attributes> returnAttributes;
        private readonly Lazy<GenericParameterDeclarations> genericParameters;
        private readonly ITypeReferenceWithReflection returnType;
        private readonly Lazy<Parameters<MethodParameterWithReflection>> parameters;
        private readonly Lazy<ILMethodBodyWithReflectionEmit> body;

        internal MethodWithReflection(ITypeWithReflection declaringType, MethodInfo method)
        {
            this.declaringType = declaringType;
            this.method = method;
            attributes = new Lazy<Attributes>(() => new Attributes(method));
            returnAttributes = new Lazy<Attributes>(() => new Attributes(method.ReturnParameter));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(method));
            returnType = TypeReferenceWithReflectionFactory.CreateReference(method.ReturnType, method);
            parameters = new Lazy<Parameters<MethodParameterWithReflection>>(
                () => new Parameters<MethodParameterWithReflection>(method, parameter => new MethodParameterWithReflection(parameter)));
            body = new Lazy<ILMethodBodyWithReflectionEmit>(() => new ILMethodBodyWithReflectionEmit(method));
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return declaringType; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return genericParameters.Value.GenericParameterDeclarationsWithReflection; }
        }
        
        public MethodInfo MethodInfo
        {
            get { return method; }
        }

        public override string Name
        {
            get { return method.Name(); }
        }

        public override IReadOnlyList<MethodParameterWithReflection> Parameters
        {
            get { return parameters.Value.ParametersWithReflection; }
        }

        public override ITypeReferenceWithReflection ReturnType
        {
            get { return returnType; }
        }
        
        public override ILMethodBodyWithReflectionEmit Body
        {
            get { return body.Value; }
        }

        public override bool IsAsync
        {
            get { return method.IsDefined(typeof(AsyncStateMachineAttribute)); }
        }

        public override IReadOnlyCollection<AttributeWithReflection> ReturnAttributes
        {
            get { return returnAttributes.Value.AttributesWithReflection; }
        }
    }
}
