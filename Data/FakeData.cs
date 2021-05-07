using System.Collections.Generic;
using FackDataBaseCRUD.Models;

namespace FackDataBaseCRUD.Data
{
    public class FakeData
    {
        public List<Employee> Employees = new List<Employee> 

        { 
            new Employee {Id = 1531, Name = "Ahmet", SureName = "Çokçalışır", Adress="Toki", Photo = "ahmet.jpg"}, 

            new Employee {Id = 1532, Name = "Mehmet", SureName = "Hiçdurmaz", Adress="Toki", Photo = "mehmet.jpg"}, 

            new Employee {Id = 1533, Name = "Hasan", SureName = "Yorulmaz", Adress="Toki", Photo = "hasan.jpg"}, 

            new Employee {Id = 1534, Name = "Hüseyin", SureName = "Kulakasmaz", Adress="Toki", Photo = "huseyin.jpg"}, 

            new Employee {Id = 1535, Name = "Ayşe", SureName = "İşyapar", Adress="Toki", Photo = "ayse.jpg"}, 

            new Employee {Id = 1536, Name = "Fatma", SureName = "Durdurakbilmez", Adress="Toki", Photo = "fatma.jpg"}, 

            new Employee {Id = 1537, Name = "Hatice", SureName = "İşbilir", Adress="Toki", Photo = "hatice.jpg"}, 

            new Employee {Id = 1538, Name = "Zeynep", SureName = "Hepçalışır", Adress="Toki", Photo = "zeynep.jpg"}, 

        }; 
    }
}