using CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedStaticClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithConstFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithInternalFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPrivateFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPublicFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithVolatileFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithVolatileField));
        }
    }
}
