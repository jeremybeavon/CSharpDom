using CSharpDom.TestTarget.Structs.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWith1GenericParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWith1ImplementedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWith2GenericParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWith2ImplementedInterfacesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithBaseClassUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithGenericParameterStructConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithInternalNestedAbstractClassUsingReflection()
        {
            TestStructAsync(typeof(StructWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public void TestStructWithPrivateNestedAbstractClassUsingReflection()
        {
            TestStructAsync(typeof(StructWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public void TestStructWithPublicNestedAbstractClassUsingReflection()
        {
            TestStructAsync(typeof(StructWithPublicNestedAbstractClass));
        }
    }
}
