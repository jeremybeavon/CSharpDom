using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyAccessor : AbstractAccessor<AttributeGroupNotSupported, ReadOnlyMethodBody>
    {
        private readonly ReadOnlyMethodBody methodBody;

        public ReadOnlyAccessor(IEnumerable<Statement> statements)
        {
            methodBody = new ReadOnlyMethodBody(statements);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override ReadOnlyMethodBody Body
        {
            get { return methodBody; }
        }
    }
}
