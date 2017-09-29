using CSharpDom.TestTarget.Structs.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedSealedClasses_Fields_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticVolatileFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewVolatileFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithReadOnlyFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticReadOnlyFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticVolatileFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithVolatileFieldUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithVolatileField));
        }
    }
}
