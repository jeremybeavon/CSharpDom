using CSharpDom.TestTarget.Structs.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStructs_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithConstFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticVolatileFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithVolatileFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithVolatileField));
        }
    }
}
