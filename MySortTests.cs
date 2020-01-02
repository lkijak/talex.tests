using LukaszKijak.Models;
using LukaszKijak.Service.SortList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace LukaszKijak.Tests
{
    public class MySortTests
    {
        [Fact]
        public void CheckSortListByTypes()
        {
            MySort sort = new MySort();

            var dateOne = DateTime.Parse("12/05/2012");
            var dateTwo = DateTime.Parse("01/01/1989");
            var dateThree = DateTime.Parse("30.09.1999");
            var dateFour = DateTime.Parse("10/09/2017");

            List<ViewModel> unSortedList = new List<ViewModel>
            {
                new ViewModel{ Type = "Folder", Name = "One", ModificationDate = dateOne, Size = 12.34, Attribute = "Hiden, Directory" },
                new ViewModel{ Type = "Folder", Name = "Two", ModificationDate = dateTwo, Size = 5.67, Attribute = "Directory" },
                new ViewModel{ Type = "File", Name = "Three", ModificationDate = dateThree, Size = 78.45, Attribute = "Archive" },
                new ViewModel{ Type = "File", Name = "Four", ModificationDate = dateFour, Size = 12.34, Attribute = "Hiden" }
            };

            var sortedList = sort.SortList(unSortedList, "Type");

            var comparativeList = unSortedList.OrderBy(o => o.Type).ToList();

            Assert.Equal(comparativeList, sortedList);
        }

        [Fact]
        public void CheckSortListByName()
        {
            MySort sort = new MySort();

            var dateOne = DateTime.Parse("12/05/2012");
            var dateTwo = DateTime.Parse("01/01/1989");
            var dateThree = DateTime.Parse("30.09.1999");
            var dateFour = DateTime.Parse("10/09/2017");

            List<ViewModel> unSortedList = new List<ViewModel>
            {
                new ViewModel{ Type = "Folder", Name = "One", ModificationDate = dateOne, Size = 12.34, Attribute = "Hiden, Directory" },
                new ViewModel{ Type = "Folder", Name = "Two", ModificationDate = dateTwo, Size = 5.67, Attribute = "Directory" },
                new ViewModel{ Type = "File", Name = "Three", ModificationDate = dateThree, Size = 78.45, Attribute = "Archive" },
                new ViewModel{ Type = "File", Name = "Four", ModificationDate = dateFour, Size = 12.34, Attribute = "Hiden" }
            };

            var sortedList = sort.SortList(unSortedList, "Name");

            var comparativeList = unSortedList.OrderBy(o => o.Name).ToList();

            Assert.Equal(comparativeList, sortedList);
        }

        [Fact]
        public void CheckSortListByModification()
        {
            MySort sort = new MySort();

            var dateOne = DateTime.Parse("12/05/2012");
            var dateTwo = DateTime.Parse("01/01/1989");
            var dateThree = DateTime.Parse("30.09.1999");
            var dateFour = DateTime.Parse("10/09/2017");

            List<ViewModel> unSortedList = new List<ViewModel>
            {
                new ViewModel{ Type = "Folder", Name = "One", ModificationDate = dateOne, Size = 12.34, Attribute = "Hiden, Directory" },
                new ViewModel{ Type = "Folder", Name = "Two", ModificationDate = dateTwo, Size = 5.67, Attribute = "Directory" },
                new ViewModel{ Type = "File", Name = "Three", ModificationDate = dateThree, Size = 78.45, Attribute = "Archive" },
                new ViewModel{ Type = "File", Name = "Four", ModificationDate = dateFour, Size = 12.34, Attribute = "Hiden" }
            };

            var sortedList = sort.SortList(unSortedList, "Modification");

            var comparativeList = unSortedList.OrderBy(o => o.ModificationDate).ToList();

            Assert.Equal(comparativeList, sortedList);
        }

        [Fact]
        public void CheckSortListBySize()
        {
            MySort sort = new MySort();

            var dateOne = DateTime.Parse("12/05/2012");
            var dateTwo = DateTime.Parse("01/01/1989");
            var dateThree = DateTime.Parse("30.09.1999");
            var dateFour = DateTime.Parse("10/09/2017");

            List<ViewModel> unSortedList = new List<ViewModel>
            {
                new ViewModel{ Type = "Folder", Name = "One", ModificationDate = dateOne, Size = 12.34, Attribute = "Hiden, Directory" },
                new ViewModel{ Type = "Folder", Name = "Two", ModificationDate = dateTwo, Size = 5.67, Attribute = "Directory" },
                new ViewModel{ Type = "File", Name = "Three", ModificationDate = dateThree, Size = 78.45, Attribute = "Archive" },
                new ViewModel{ Type = "File", Name = "Four", ModificationDate = dateFour, Size = 12.34, Attribute = "Hiden" }
            };

            var sortedList = sort.SortList(unSortedList, "Size");

            var comparativeList = unSortedList.OrderBy(o => o.Size).ToList();

            Assert.Equal(comparativeList, sortedList);
        }

        [Fact]
        public void CheckSortListByAttribute()
        {
            MySort sort = new MySort();

            var dateOne = DateTime.Parse("12/05/2012");
            var dateTwo = DateTime.Parse("01/01/1989");
            var dateThree = DateTime.Parse("30.09.1999");
            var dateFour = DateTime.Parse("10/09/2017");

            List<ViewModel> unSortedList = new List<ViewModel>
            {
                new ViewModel{ Type = "Folder", Name = "One", ModificationDate = dateOne, Size = 12.34, Attribute = "Hiden, Directory" },
                new ViewModel{ Type = "Folder", Name = "Two", ModificationDate = dateTwo, Size = 5.67, Attribute = "Directory" },
                new ViewModel{ Type = "File", Name = "Three", ModificationDate = dateThree, Size = 78.45, Attribute = "Archive" },
                new ViewModel{ Type = "File", Name = "Four", ModificationDate = dateFour, Size = 12.34, Attribute = "Hiden" }
            };

            var sortedList = sort.SortList(unSortedList, "Attribute");

            var comparativeList = unSortedList.OrderBy(o => o.Attribute).ToList();

            Assert.Equal(comparativeList, sortedList);
        }


        [Fact]
        public void CheckSortListByTypesDescending()
        {
            MySort sort = new MySort();

            var dateOne = DateTime.Parse("12/05/2012");
            var dateTwo = DateTime.Parse("01/01/1989");
            var dateThree = DateTime.Parse("30.09.1999");
            var dateFour = DateTime.Parse("10/09/2017");

            List<ViewModel> unSortedList = new List<ViewModel>
            {
                new ViewModel{ Type = "Folder", Name = "One", ModificationDate = dateOne, Size = 12.34, Attribute = "Hiden, Directory" },
                new ViewModel{ Type = "Folder", Name = "Two", ModificationDate = dateTwo, Size = 5.67, Attribute = "Directory" },
                new ViewModel{ Type = "File", Name = "Three", ModificationDate = dateThree, Size = 78.45, Attribute = "Archive" },
                new ViewModel{ Type = "File", Name = "Four", ModificationDate = dateFour, Size = 12.34, Attribute = "Hiden" }
            };

            var sortedList = sort.SortList(unSortedList, "TypeDescending");

            var comparativeList = unSortedList.OrderByDescending(o => o.Type).ToList();

            Assert.Equal(comparativeList, sortedList);
        }

        [Fact]
        public void CheckSortListByNameDescending()
        {
            MySort sort = new MySort();

            var dateOne = DateTime.Parse("12/05/2012");
            var dateTwo = DateTime.Parse("01/01/1989");
            var dateThree = DateTime.Parse("30.09.1999");
            var dateFour = DateTime.Parse("10/09/2017");

            List<ViewModel> unSortedList = new List<ViewModel>
            {
                new ViewModel{ Type = "Folder", Name = "One", ModificationDate = dateOne, Size = 12.34, Attribute = "Hiden, Directory" },
                new ViewModel{ Type = "Folder", Name = "Two", ModificationDate = dateTwo, Size = 5.67, Attribute = "Directory" },
                new ViewModel{ Type = "File", Name = "Three", ModificationDate = dateThree, Size = 78.45, Attribute = "Archive" },
                new ViewModel{ Type = "File", Name = "Four", ModificationDate = dateFour, Size = 12.34, Attribute = "Hiden" }
            };

            var sortedList = sort.SortList(unSortedList, "NameDescending");

            var comparativeList = unSortedList.OrderByDescending(o => o.Name).ToList();

            Assert.Equal(comparativeList, sortedList);
        }

        [Fact]
        public void CheckSortListByModificationDescending()
        {
            MySort sort = new MySort();

            var dateOne = DateTime.Parse("12/05/2012");
            var dateTwo = DateTime.Parse("01/01/1989");
            var dateThree = DateTime.Parse("30.09.1999");
            var dateFour = DateTime.Parse("10/09/2017");

            List<ViewModel> unSortedList = new List<ViewModel>
            {
                new ViewModel{ Type = "Folder", Name = "One", ModificationDate = dateOne, Size = 12.34, Attribute = "Hiden, Directory" },
                new ViewModel{ Type = "Folder", Name = "Two", ModificationDate = dateTwo, Size = 5.67, Attribute = "Directory" },
                new ViewModel{ Type = "File", Name = "Three", ModificationDate = dateThree, Size = 78.45, Attribute = "Archive" },
                new ViewModel{ Type = "File", Name = "Four", ModificationDate = dateFour, Size = 12.34, Attribute = "Hiden" }
            };

            var sortedList = sort.SortList(unSortedList, "ModificationDescending");

            var comparativeList = unSortedList.OrderByDescending(o => o.ModificationDate).ToList();

            Assert.Equal(comparativeList, sortedList);
        }

        [Fact]
        public void CheckSortListBySizeDescending()
        {
            MySort sort = new MySort();

            var dateOne = DateTime.Parse("12/05/2012");
            var dateTwo = DateTime.Parse("01/01/1989");
            var dateThree = DateTime.Parse("30.09.1999");
            var dateFour = DateTime.Parse("10/09/2017");

            List<ViewModel> unSortedList = new List<ViewModel>
            {
                new ViewModel{ Type = "Folder", Name = "One", ModificationDate = dateOne, Size = 12.34, Attribute = "Hiden, Directory" },
                new ViewModel{ Type = "Folder", Name = "Two", ModificationDate = dateTwo, Size = 5.67, Attribute = "Directory" },
                new ViewModel{ Type = "File", Name = "Three", ModificationDate = dateThree, Size = 78.45, Attribute = "Archive" },
                new ViewModel{ Type = "File", Name = "Four", ModificationDate = dateFour, Size = 12.34, Attribute = "Hiden" }
            };

            var sortedList = sort.SortList(unSortedList, "SizeDescending");

            var comparativeList = unSortedList.OrderByDescending(o => o.Size).ToList();

            Assert.Equal(comparativeList, sortedList);
        }

        [Fact]
        public void CheckSortListByAttributeDescending()
        {
            MySort sort = new MySort();

            var dateOne = DateTime.Parse("12/05/2012");
            var dateTwo = DateTime.Parse("01/01/1989");
            var dateThree = DateTime.Parse("30.09.1999");
            var dateFour = DateTime.Parse("10/09/2017");

            List<ViewModel> unSortedList = new List<ViewModel>
            {
                new ViewModel{ Type = "Folder", Name = "One", ModificationDate = dateOne, Size = 12.34, Attribute = "Hiden, Directory" },
                new ViewModel{ Type = "Folder", Name = "Two", ModificationDate = dateTwo, Size = 5.67, Attribute = "Directory" },
                new ViewModel{ Type = "File", Name = "Three", ModificationDate = dateThree, Size = 78.45, Attribute = "Archive" },
                new ViewModel{ Type = "File", Name = "Four", ModificationDate = dateFour, Size = 12.34, Attribute = "Hiden" }
            };

            var sortedList = sort.SortList(unSortedList, "AttributeDescending");

            var comparativeList = unSortedList.OrderByDescending(o => o.Attribute).ToList();

            Assert.Equal(comparativeList, sortedList);
        }

        [Fact]
        public void CheckSortList()
        {
            MySort sort = new MySort();

            var dateOne = DateTime.Parse("12/05/2012");
            var dateTwo = DateTime.Parse("01/01/1989");
            var dateThree = DateTime.Parse("30.09.1999");
            var dateFour = DateTime.Parse("10/09/2017");

            List<ViewModel> unSortedList = new List<ViewModel>
            {
                new ViewModel{ Type = "Folder", Name = "One", ModificationDate = dateOne, Size = 12.34, Attribute = "Hiden, Directory" },
                new ViewModel{ Type = "Folder", Name = "Two", ModificationDate = dateTwo, Size = 5.67, Attribute = "Directory" },
                new ViewModel{ Type = "File", Name = "Three", ModificationDate = dateThree, Size = 78.45, Attribute = "Archive" },
                new ViewModel{ Type = "File", Name = "Four", ModificationDate = dateFour, Size = 12.34, Attribute = "Hiden" }
            };

            var sortedList = sort.SortList(unSortedList, "ABC");

            Assert.Same(sortedList, unSortedList);
        }
    }
}
