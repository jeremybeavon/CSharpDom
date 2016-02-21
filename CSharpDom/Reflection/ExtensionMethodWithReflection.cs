using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class ExtensionMethodWithReflection :
        AbstractExtensionMethod<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            ITypeReferenceWithReflection,
            ExtensionParameterWithReflection,
            MethodParameterWithReflection,
            ILMethodBodyWithReflectionEmit>
    {
        private readonly MethodWithReflection method;
        private readonly ExtensionParameterWithReflection extensionParameter;
        private readonly IReadOnlyList<MethodParameterWithReflection> parameters;

        internal ExtensionMethodWithReflection(ITypeWithReflection declaringType, MethodInfo method)
        {
            this.method = new MethodWithReflection(declaringType, method);
            extensionParameter = new ExtensionParameterWithReflection(this.method.Parameters[0]);
            parameters = this.method.Parameters.Skip(1).ToArray();
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return method.Attributes; }
        }

        public override ILMethodBodyWithReflectionEmit Body
        {
            get { return method.Body; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return method.DeclaringType; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return method.GenericParameters; }
        }
        
        public override string Name
        {
            get { return method.Name; }
        }

        public override IReadOnlyList<MethodParameterWithReflection> Parameters
        {
            get { return parameters; }
        }

        public override ITypeReferenceWithReflection ReturnType
        {
            get { return method.ReturnType; }
        }

        public override ExtensionParameterWithReflection ExtensionParameter
        {
            get { return extensionParameter; }
        }

        public override bool IsAsync
        {
            get { return method.IsAsync; }
        }
    }
}
