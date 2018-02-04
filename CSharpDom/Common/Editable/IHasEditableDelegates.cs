using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableDelegates<TDelegate> : IHasDelegates<TDelegate>
    {
        new ICollection<TDelegate> Delegates { get; set; }
    }
}