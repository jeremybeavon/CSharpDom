using CSharpDom.TestTarget.Classes.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithConstFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithConstField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithInternalFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPrivateFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithReadOnlyFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithStaticFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithStaticReadOnlyFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithStaticVolatileFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithVolatileFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithVolatileField));
        }
    }
}
