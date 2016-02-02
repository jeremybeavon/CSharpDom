using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using System.Reflection;
using CSharpDom.Reflection.Emit;
using CSharpDom.NotSupported;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class MethodWithReflection :
        AbstractMethod<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            ITypeReferenceWithReflection,
            ParameterWithReflection,
            ILMethodBodyWithReflectionEmit>,
        IHasMethodInfo
    {
        private readonly ITypeWithReflection declaringType;
        private readonly MethodInfo method;
        private readonly Lazy<Attributes> attributes;
        private readonly Lazy<GenericParameterDeclarations> genericParameters;
        private readonly ITypeReferenceWithReflection returnType;
        private readonly Lazy<Parameters> parameters;

        internal MethodWithReflection(ITypeWithReflection declaringType, MethodInfo method)
        {
            this.declaringType = declaringType;
            this.method = method;
            attributes = new Lazy<Attributes>(() => new Attributes(method));
            genericParameters = new Lazy<GenericParameterDeclarations>(() => new GenericParameterDeclarations(method));
            returnType = TypeReferenceWithReflectionFactory.CreateReference(method.ReturnType);
            parameters = new Lazy<Parameters>(() => new Parameters(method));
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
        
        public override bool IsAsync
        {
            get { return false; }
        }

        public override bool IsPartial
        {
            get { return false; }
        }

        public MethodInfo MethodInfo
        {
            get { return method; }
        }

        public override string Name
        {
            get { return method.Name; }
        }

        public override IReadOnlyList<ParameterWithReflection> Parameters
        {
            get { return parameters.Value.ParametersWithReflection; }
        }

        public override ITypeReferenceWithReflection ReturnType
        {
            get { return returnType; }
        }
        
        public override ILMethodBodyWithReflectionEmit Body
        {
            get { throw new NotImplementedException(); }
        }
        
    }
}
