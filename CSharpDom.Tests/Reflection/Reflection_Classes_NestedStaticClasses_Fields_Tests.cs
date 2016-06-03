using CSharpDom.TestTarget.Classes.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStaticClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithConstFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithInternalFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPrivateFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPublicFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithReadOnlyFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithVolatileFieldUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithVolatileField));
        }
    }
}
