using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_Methods_ExplicitInterfaceMethods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithExplicitInterfaceMethodWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithExplicitInterfaceMethodWith1GenericParameterUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithExplicitInterfaceMethodWith2GenericParametersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithExplicitInterfaceMethodWithParametersWithAttributesUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithExplicitInterfaceMethodWithParametersWithModifiersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}
