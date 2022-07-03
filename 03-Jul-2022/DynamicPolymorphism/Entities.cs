using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphism
{
    public class Student
    {

        public string collegeName;
        public virtual  string GetFavouriteMovie()
        {
            return "3 idiots";
        }
    }

    public class Vraj: Student
    {
        public override  string GetFavouriteMovie()
        {
            return "Spiderman";
        }
    }

    public class Bharatesh : Student
    {
        public override string GetFavouriteMovie()
        {
            return "KGF";
        }
    }


    public class Hemant : Student
    {
        public override string GetFavouriteMovie()
        {
            return "KGF2";
        }
    }

    public class Ganesh : Student
    {
        public override string GetFavouriteMovie()
        {
            return "Black Panther";
        }
    }


}
