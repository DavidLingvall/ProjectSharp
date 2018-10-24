using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSharp
{
    class CategoryList : List<Category>
    {

        public List<Category> Categorys = new List<Category>();


        public CategoryList()
        {

        }

        public void AddCategoryToListTest()
        {
            Categorys.Add(new Category("Horror"));
            Categorys.Add(new Category("Fact"));
            Categorys.Add(new Category("Fun"));
        }

        public void AddCategoryToList(Category NewCategory)
        {
            Categorys.Add(NewCategory);
        }

        


    }


}
