namespace CSharpDom.Common.IL
{
    /*
    Review:
    LoadTypeReference = mkrefany
    LoadAddress = refanyval
    */

    public enum TypeInstructionType
    {
        Box,
        Cast,
        Constrained,
        CopyObject,
        InitializeObject,
        IsInstanceOfClass,
        LoadArrayElement,
        LoadArrayElementAddress,
        LoadObject,
        LoadTypeReference,
        NewArray,
        LoadAddress,
        SizeOf,
        StoreArrayElement,
        StoreObject,
        Unbox,
        UnboxAny
    }
}
