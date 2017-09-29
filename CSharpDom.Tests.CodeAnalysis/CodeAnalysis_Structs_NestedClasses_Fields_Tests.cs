using CSharpDom.TestTarget.Structs.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithConstFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVolatileFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithVolatileField));
        }
    }
}
