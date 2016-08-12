using CSharpDom.TestTarget.Structs.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithInternalEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithPrivateEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithPublicEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStructWithStaticEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithStaticEventProperty));
        }
    }
}
