using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableSealedClasses<TSealedClass> : IHasSealedClasses<TSealedClass>
    {
        new ICollection<TSealedClass> SealedClasses { get; set; }
    }
}