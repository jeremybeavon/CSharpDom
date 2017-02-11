using CSharpDom.TestTarget.Structs.NestedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith1GenericParameterUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith2GenericParametersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNewMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVirtualMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithSealedOverrideMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithStaticMethod));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualMethodUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithVirtualMethod));
        }
    }
}
