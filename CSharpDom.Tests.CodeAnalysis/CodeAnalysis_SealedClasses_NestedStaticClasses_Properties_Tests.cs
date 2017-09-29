using CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedStaticClasses_Properties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithInternalPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithInternalProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPrivatePropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPublicPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPublicProperty));
        }
    }
}
