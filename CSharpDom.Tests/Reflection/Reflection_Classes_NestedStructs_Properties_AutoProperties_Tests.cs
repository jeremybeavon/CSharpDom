using CSharpDom.TestTarget.Classes.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithInternalAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPrivateAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithStaticAutoPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithStaticAutoProperty));
        }
    }
}
