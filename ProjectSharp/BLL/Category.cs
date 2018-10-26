using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSharp
{
    public class Category
    {
        public List<Category> CategoryList = new List<Category>();
        public string Name { get; set; }

        public Category()
        {

        }

        public Category(string name)
        {
            Name = name;
        } 
        
        public void AddToList(Category NewCategory)
        {
            CategoryList.Add(NewCategory);
        }

        public void RemoveFromList(string CategoryName)
        {
            Category CategoryRef = new Category();

            foreach(var Category in CategoryList)
            {
                if (Category.Name == CategoryName)
                {
                    CategoryRef = Category;
                }
            }

            if (CategoryRef != null)
            {
                CategoryList.Remove(CategoryRef);
            }
            
        }

        public void WriteListToFile()
        {
            using (StreamWriter sw = new StreamWriter(@"Categories.txt"))
            {                
                foreach(var Category in CategoryList)
                {
                    sw.WriteLine(Category.Name);
                }
            }
        }

        public void ReadFileToList()
        {
            using (StreamReader sr = new StreamReader(@"Categories.txt"))
            {
                string s;
                do
                {
                    s = sr.ReadLine();
                    if (s != "")
                    {                     
                        CategoryList.Add(new Category(s));
                    }
                    
                } while (s != null);
            }
        }


    }
}
