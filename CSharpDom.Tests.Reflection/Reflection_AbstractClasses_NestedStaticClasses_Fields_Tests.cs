using CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedStaticClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithConstFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithInternalFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithPrivateFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithPublicFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithReadOnlyFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithVolatileFieldUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithVolatileField));
        }
    }
}
