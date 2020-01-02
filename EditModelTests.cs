using LukaszKijak.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LukaszKijak.Tests
{
    public class EditModelTests
    {
        [Fact]
        public void CanChangeEditModelNewName()
        {
            EditModel model = new EditModel
            {
                NewName = "Luk",
                OldName = "Jack"
            };

            model.NewName = "Mick";

            Assert.Equal("Mick", model.NewName);
        }

        [Fact]
        public void CanChangeEditModelOldName()
        {
            EditModel model = new EditModel
            {
                NewName = "Luk",
                OldName = "Jack"
            };

            model.OldName = "Mick";

            Assert.Equal("Mick", model.OldName);
        }


    }
}
