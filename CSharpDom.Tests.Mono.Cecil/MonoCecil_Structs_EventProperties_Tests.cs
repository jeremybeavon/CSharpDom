using CSharpDom.TestTarget.Structs.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithInternalEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithPrivateEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithPublicEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStructWithStaticEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithStaticEventProperty));
        }
    }
}
