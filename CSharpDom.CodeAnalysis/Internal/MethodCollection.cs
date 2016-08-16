using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class MethodCollection<TConstructor, TMethod, TType> :
        VisitableNotSupported<IGenericVisitor>,
        IMethodCollection
        where TType : ITypeWithCodeAnalysis
    {
        private readonly Lazy<Methods<TConstructor, TMethod, TType>> methods;

        public MethodCollection(Func<Methods<TConstructor, TMethod, TType>> methods)
        {
            this.methods = new Lazy<Methods<TConstructor, TMethod, TType>>(methods);
        }

        public Methods<TConstructor, TMethod, TType> Methods
        {
            get { return methods.Value; }
        }
    }
}
