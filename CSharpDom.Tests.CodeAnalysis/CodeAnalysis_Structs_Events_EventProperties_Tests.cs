using CSharpDom.TestTarget.Structs.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithInternalEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithPrivateEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithPublicEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStructWithStaticEventPropertyUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithStaticEventProperty));
        }
    }
}
