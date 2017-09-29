using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVolatileFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithVolatileField));
        }
    }
}
