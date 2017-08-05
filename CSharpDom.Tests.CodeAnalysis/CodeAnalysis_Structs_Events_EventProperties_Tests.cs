using CSharpDom.TestTarget.Structs.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithInternalEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithPrivateEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithPublicEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithStaticEventPropertyUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithStaticEventProperty));
        }
    }
}
