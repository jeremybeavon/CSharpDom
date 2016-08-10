using CSharpDom.TestTarget.Structs.NestedStaticClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStaticClasses_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivateMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicMethodUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPublicMethod));
        }
    }
}
