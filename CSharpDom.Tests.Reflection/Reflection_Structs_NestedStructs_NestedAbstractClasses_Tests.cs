using CSharpDom.TestTarget.Structs.NestedStructs.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_NestedAbstractClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithNestedAbstractClassWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedAbstractClassWith1GenericParameterUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedAbstractClassWith1ImplementedInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedAbstractClassWith2GenericParametersUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedAbstractClassWith2ImplementedInterfacesUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedAbstractClassWithBaseClassUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedAbstractClassWithGenericParameterClassConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithNestedAbstractClassWithGenericParameterStructConstraintUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalNestedAbstractClassUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateNestedAbstractClassUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicNestedAbstractClassUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicNestedAbstractClass));
        }
    }
}
