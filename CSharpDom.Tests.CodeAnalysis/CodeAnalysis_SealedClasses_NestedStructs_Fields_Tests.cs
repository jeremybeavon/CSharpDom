using CSharpDom.TestTarget.SealedClasses.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedStructs_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithConstFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithStaticFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithStaticVolatileFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithVolatileFieldUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithVolatileField));
        }
    }
}
