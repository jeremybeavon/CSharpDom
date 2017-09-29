using CSharpDom.TestTarget.SealedClasses.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithStaticAutoPropertyUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticAutoProperty));
        }
    }
}
