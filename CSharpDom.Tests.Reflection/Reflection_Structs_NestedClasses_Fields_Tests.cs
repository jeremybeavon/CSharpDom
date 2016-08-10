using CSharpDom.TestTarget.Structs.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithConstFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVolatileFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithReadOnlyFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticVolatileFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVolatileFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithVolatileField));
        }
    }
}
