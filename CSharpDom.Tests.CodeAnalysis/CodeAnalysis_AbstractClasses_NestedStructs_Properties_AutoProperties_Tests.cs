using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStructWithInternalAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPrivateAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPublicAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithStaticAutoPropertyUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithStaticAutoProperty));
        }
    }
}
