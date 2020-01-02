using LukaszKijak.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LukaszKijak.Tests
{
    public class ViewModelTests
    {
        [Fact]
        public void CanChangeViewModelType()
        {
            ViewModel model = new ViewModel
            {
                Type = "Type one",
                Name = "Name one",
                ModificationDate = DateTime.Now,
                Size = 123.45,
                Attribute = "Attribute one",
                MyPath = "MyPath one"
            };

            model.Type = "Type two";

            Assert.Equal("Type two", model.Type);
        }

        [Fact]
        public void CanChangeViewModelName()
        {
            ViewModel model = new ViewModel
            {
                Type = "Type one",
                Name = "Name one",
                ModificationDate = DateTime.Now,
                Size = 123.45,
                Attribute = "Attribute one",
                MyPath = "MyPath one"
            };

            model.Name = "Name two";

            Assert.Equal("Name two", model.Name);
        }

        [Fact]
        public void CanChangeViewModelModificationDate()
        {
            ViewModel model = new ViewModel
            {
                Type = "Type one",
                Name = "Name one",
                ModificationDate = DateTime.Now,
                Size = 123.45,
                Attribute = "Attribute one",
                MyPath = "MyPath one"
            };

            model.ModificationDate = DateTime.Today;

            Assert.Equal(DateTime.Today, model.ModificationDate);
        }

        [Fact]
        public void CanChangeViewModelSize()
        {
            ViewModel model = new ViewModel
            {
                Type = "Type one",
                Name = "Name one",
                ModificationDate = DateTime.Now,
                Size = 123.45,
                Attribute = "Attribute one",
                MyPath = "MyPath one"
            };

            model.Size = 678.91;

            Assert.Equal(678.91, model.Size);
        }

        [Fact]
        public void CanChangeViewModelAttribute()
        {
            ViewModel model = new ViewModel
            {
                Type = "Type one",
                Name = "Name one",
                ModificationDate = DateTime.Now,
                Size = 123.45,
                Attribute = "Attribute one",
                MyPath = "MyPath one"
            };

            model.Attribute = "Attribute two";

            Assert.Equal("Attribute two", model.Attribute);
        }

        [Fact]
        public void CanChangeViewModelMyPath()
        {
            ViewModel model = new ViewModel
            {
                Type = "Type one",
                Name = "Name one",
                ModificationDate = DateTime.Now,
                Size = 123.45,
                Attribute = "Attribute one",
                MyPath = "MyPath one"
            };

            model.MyPath = "MyPath two";

            Assert.Equal("MyPath two", model.MyPath);
        }
    }
}
