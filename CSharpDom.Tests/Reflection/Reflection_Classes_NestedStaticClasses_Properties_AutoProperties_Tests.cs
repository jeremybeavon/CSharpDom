using CSharpDom.TestTarget.Classes.NestedStaticClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStaticClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithInternalAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPrivateAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPublicAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicAutoProperty));
        }
    }
}
