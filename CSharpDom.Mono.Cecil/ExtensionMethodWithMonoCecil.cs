using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ExtensionMethodWithMonoCecil :
        AbstractExtensionMethod<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            GenericParameterDeclarationWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            ExtensionParameterWithMonoCecil,
            MethodParameterWithMonoCecil,
            ILMethodBodyWithMonoCecilEmit>
    {
        private readonly MethodWithMonoCecil method;
        private readonly ExtensionParameterWithMonoCecil extensionParameter;
        private readonly IReadOnlyList<MethodParameterWithMonoCecil> parameters;

        internal ExtensionMethodWithMonoCecil(ITypeWithMonoCecil declaringType, MethodInfo method)
        {
            this.method = new MethodWithMonoCecil(declaringType, method);
            extensionParameter = new ExtensionParameterWithMonoCecil(this.method.Parameters[0]);
            parameters = this.method.Parameters.Skip(1).ToArray();
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return method.Attributes; }
        }

        public override ILMethodBodyWithMonoCecilEmit Body
        {
            get { return method.Body; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return method.DeclaringType; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithMonoCecil> GenericParameters
        {
            get { return method.GenericParameters; }
        }
        
        public override string Name
        {
            get { return method.Name; }
        }

        public override IReadOnlyList<MethodParameterWithMonoCecil> Parameters
        {
            get { return parameters; }
        }

        public override ITypeReferenceWithMonoCecil ReturnType
        {
            get { return method.ReturnType; }
        }

        public override ExtensionParameterWithMonoCecil ExtensionParameter
        {
            get { return extensionParameter; }
        }

        public override bool IsAsync
        {
            get { return method.IsAsync; }
        }
    }
}
