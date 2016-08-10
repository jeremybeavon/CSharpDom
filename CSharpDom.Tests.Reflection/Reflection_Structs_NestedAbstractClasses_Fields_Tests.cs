using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVolatileFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithReadOnlyFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticVolatileFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVolatileFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithVolatileField));
        }
    }
}
