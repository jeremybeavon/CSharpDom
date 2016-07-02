using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedStaticClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithConstFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithInternalFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPrivateFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPublicFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithReadOnlyFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithVolatileFieldUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithVolatileField));
        }
    }
}
