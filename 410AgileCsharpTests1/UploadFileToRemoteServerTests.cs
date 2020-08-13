﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using _410AgileCsharp;
using UploadFileToRemoteServer;
using System.Net;

namespace ListFilesOnRemoteServer.Tests
{
    [TestClass()]
    public class UploadFileToRemoteServerTests
    {
        [TestMethod()]
        public void UploadFileToRemoteServer_Upload_SuccesfulResult()
        {
			//Arrange
			var mainRequest = new FtpHandler
			{
				url = "ftp://13.59.40.218/",
				userName = "ftp_user",
				securePwd = new NetworkCredential("", "Kamono123").SecurePassword
			};
			var upload = new Upload();
            //Act
            var response = upload.UploadToRemote(mainRequest, "SavedConnections.txt");
            //Assert
            Assert.IsTrue(response);
        }

        [TestMethod()]
        public void UploadFileToRemoteServer_Upload_FailureResult()
        {
			var mainRequest = new FtpHandler
			{
				url = "ftp://13.59.40.218/",
				userName = "ftp_user",
				securePwd = new NetworkCredential("", "Kamono12345").SecurePassword
			};
			var upload = new Upload();
            //Act
            var response = upload.UploadToRemote(mainRequest, "SavedConnections.txt");
            //Assert
            Assert.IsFalse(response);
        }
    }
}