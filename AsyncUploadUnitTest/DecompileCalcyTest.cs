using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AngularNetAsyncUpload.Models;

namespace AsyncUploadUnitTest
{
    [TestClass]
    public class DecompileCalcyTest
    {

        DecompilerCalcy decompiler;

        [TestInitialize]
        public void Init()
        {
            decompiler = new DecompilerCalcy();
        }

        [TestMethod]
        public void DecompileCalcy_Decompile_Succes()
        {
            //Arrange
            string location = @"C:\Users\Linksonder\Documents\Visual Studio 2013\Projects\2. Pocs\Calcy\Calcy\bin\Debug\Calcy.exe";

            //Act
            decompiler.Decompile(location);

            //Assert

        }
    }
}
