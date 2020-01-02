using LukaszKijak.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LukaszKijak.Tests
{
    public class ContentTypeTests
    {
        [Fact]
        public void CkeckGetContentType()
        {
            ContentType content = new ContentType();

            var path = "text/cs";
            var testPath = content.GetContentType("test.cs");

            Assert.Equal(path, testPath);
        }

    }
}
