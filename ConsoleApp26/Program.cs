using System;
namespace Tamrin
{
    public class Teacher
    {
        private String id;
        private String name;
        private String lastname;
        private int hour;
        private int payperonehour;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Name
        {
            get { return name; }
            set { name = value; }  
        }
        public string Lastname
        {
            get { return lastname; }   
            set { lastname = value; }
        }
        public int Hour
        {
            get { return hour; }
            set { hour = value; }
        }
        public int Payperonehour
        {
            get { return payperonehour; }
            set { if(value>0)
                {
                    payperonehour = value;
                }
            }
        }

        public Teacher() { } //mokharreb function
        public Teacher(String Id,String Name , String Lastname , int Hour , int Payperonehour)
        {
            id= Id;
            name=Name;
            lastname= Lastname; 
            hour= Hour; 
            payperonehour= Payperonehour;

        }//sazande function
        private long Payment()
        {
            return hour * Payperonehour;
        }
      
    }
}