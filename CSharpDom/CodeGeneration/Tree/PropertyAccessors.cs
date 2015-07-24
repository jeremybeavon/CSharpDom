using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    internal sealed class PropertyAccessors<TAccessor> : ICodeGenerationNode
        where TAccessor : CodeGenerationNode
    {
        private readonly TAccessor getAccessor;
        private readonly TAccessor setAccessor;

        public PropertyAccessors(TAccessor getAccessor, TAccessor setAccessor)
        {
            this.getAccessor = getAccessor;
            this.setAccessor = setAccessor;
        }

        public void Accept(CodeGenerationVisitor visitor)
        {
            getAccessor.AcceptIfNotNull(visitor);
            setAccessor.AcceptIfNotNull(visitor);
        }
    }
}
