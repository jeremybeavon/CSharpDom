using CSharpDom.Common;

namespace CSharpDom.NotSupported
{
    public sealed class PropertyNotSupported :
        VisitableNotSupported<IGenericVisitor>,
        IClassAutoProperty,
        IClassLambdaProperty,
        IClassProperty,
        ISealedClassAutoProperty,
        ISealedClassLambdaProperty,
        ISealedClassProperty,
        IStaticClassAutoProperty,
        IStaticClassLambdaProperty,
        IStaticClassProperty,
        IStructAutoProperty,
        IStructLambdaProperty,
        IStructProperty
    {
    }
}
