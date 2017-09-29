using CSharpDom.TestTarget.Structs.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStaticClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedStaticClassWithConstFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivateFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithVolatileFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithVolatileField));
        }
    }
}
