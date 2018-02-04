using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableClassCollection<TClassCollection> : IHasClassCollection<TClassCollection>
    {
        new TClassCollection Classes { get; set; }
    }
}